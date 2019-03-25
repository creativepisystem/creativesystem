/****************************************************************************
 * No modulo User é feita todo o controle que se refere a criação,
 * login e logout dos usuarios no sistema, além das criação das
 * rotas para cada serviço HTTP.
 * 
 * Tudo dentro do User controller é acessado por:
 *  https://URL_PADRAO/user/ROTA_DA_FUNÇÃO
 * 
 * Todos os servições,com excessão do login, tem que ser acessados com uma
 * autenticação gerado no metódo de login.
 * 
 * Cada método acessa um Sevice que ira conter as regras de negócio e requerir
 * os dados do banco.
 ***************************************************************************/
const express = require('express');
const validateUser = require("./../utils/ValidateUser");
const secureUser = require("./../utils/SecureUser")
const User = require("./../Class/User");
// Importação do Service
const userService = require('./../Service/UserService');
// Criação do Servidor do Módulo User
UserApp = express();
// Serviço de Criação do Usuario
UserApp.post('/', function (req, res) {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    },
        async function (user) {
            if (await validateUser.create(user, req.body)) {
                res.status(400).send("Dados Invalidos")
            } else {
                user = new User(await userService.saveUser(req.body)).get();
                if (user == null) {
                    res.status(400).send("Erro ao criar o Usuario");
                } else {
                    delete user.user.password;
                    res.status(201).send(user.user);
                }
            }
        }, () => {
            res.status(401).send("não autorizado");
        });
});
//update senha
UserApp.put('/:user', function (req, res) {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    },
        async function (user) {
            if (validateUser.update(req.body)) {
                res.status(400).send("Dados Invalidos");
            } else {
                var userUpdate;
                if (req.params.user == user.getUser())
                    userUpdate = user;
                else
                    userUpdate = await userService.findUser(req.params.user);
                if (userUpdate == null) {
                    res.status(400).send("Usuario invalido");
                }
                else {
                    if (user.getType() > userUpdate.getType() && user.getUser() != userUpdate.getUser())
                        res.status(401).send("Você não é autorizado a fazer essa alteração!");
                    else {
                        userUpdate = await userService.updateUser({
                            newUser: req.body,
                            user: userUpdate
                        });
                        if (userUpdate == null) {
                            res.status(400).send("Erro ao criar o Usuario");
                        } else {
                            res.status(201).send(userUpdate);
                        }
                    }
                }
            }
        }, () => {
            res.status(401).send("não autorizado");
        }
    );
});
//Serviço de Criação de login
UserApp.post('/login', async function (req, res) {
    let auth = await userService.login({
        user: req.header('user'),
        password: req.header('password')
    });
    if (auth === null) {
        res.status(400).send("Erro");
    } else {
        res.status(200).send(auth);
    }
});
//Serviço de logout do Usuario
UserApp.post('/logout', function (req, res) {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    }, async function (user) {
        let userLogout = await userService.logout(user);
        if (userLogout === null) {
            res.status(400).send("Erro");
        } else {
            res.status(200).send(userLogout);
        }
    }, () => {
        res.status(401).send("não autorizado");
    });
});

//Serviço de recovery do Usuario
UserApp.post('/recovery/:user', async function (req, res) {
    let user = await userService.findUser(req.params.user);
    if (user.get() === null) {
        res.status(400).send("Usuario Invalido")
    } else {
        userRecovery = await userService.recoveryUser(user, () => {
            res.status(201).send("ok");
        },
            () => {
                res.status(400).send("Erro ao modificar senha");
            });
    }
});
UserApp.get("/", (req, res) => {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    }, async (user) => {
        res.status(200).send(await userService.findAll(user));
    }, () => {
        res.status(400).send("Erro ao buscar os usuarios");
    });
});
UserApp.get("/:id", (req, res) => {
    validateUser.auth({
        user: req.header('user'),
        auth: req.header('auth')
    }, async (user) => {
        if (user.getId() == req.params.id) {
            res.status(200).send(secureUser(user));
        } else {
            let findUser = await userService.find(user, req.params.id);
            if (findUser == null)
                res.status(400).send("Erro ao buscar os usuario");
            else
                res.status(200).send(findUser.get());
        }

    }, () => {
        res.status(401).send("Usuario não autorizado");
    });
});
module.exports = UserApp;