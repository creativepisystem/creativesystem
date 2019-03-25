/********************************************************************************************
 * O UserRepsitory é responsavel por acessar o banco, criar,deletar,fazer Updates e buscar
 * dados quando solicitado
 *******************************************************************************************/
//Importação do Banco de Dados
const db = require("./../Config/ConnectionDB");
//Criação da referencia a Collection Usuarios
const userRef = db.collection("users");
//Importação do Util para deleção de campos
const deleteField = require("../utils/DeleteField");
const User = require("./../Class/User")
//Declaração da classe UserRepository
class UserRepository {
    constructor() { }
    //Método de save do usuario
    save(user) {
        return userRef.add(user).then((doc) => {
            user.id = doc.id
            return new User(user);
        }).catch(() => {
            return null;
        });
    }
    async update(user) {
        let updateUser = user.get();
        let id = updateUser.id;
        delete updateUser.id;
        return userRef.doc(id).update(updateUser).then(() => {
            return "ok";
        }).catch(() => {
            return null;
        });
    }
    //Busca de Usuario pelo user
    async findByUser(user) {
        return await userRef.where("user", "==", user).get().then((querySnapshot => {
            if (querySnapshot.docs.length != 1) {
                return null;
            }
            user = querySnapshot.docs[0].data();
            user.id = querySnapshot.docs[0].id
            return new User(user);
        })).catch(() => {
            return null;
        });
    }
    //Busca do Id do Usuario por User e Pass(Password)
    findByUserAndPass(user) {
        return userRef.where("user", "==", user.user).where("password", "==", user.password)
            .get().then((querySnapshot => {
                if (querySnapshot.docs.length == 1) {
                    user = querySnapshot.docs[0].data();
                    user.id = querySnapshot.docs[0].id;
                    return new User(user);
                }
                return null;
            }));
    }
    //Busca Id pelo User e Auth(Token)
    findByUserAndAuth(user) {
        return userRef.where("user", "==", user.user).where("auth", "==", user.auth)
            .get().then((querySnapshot => {
                if (querySnapshot.docs.length == 1) {
                    user = querySnapshot.docs[0].data();
                    user.id = querySnapshot.docs[0].id;
                    return new User(user);
                }
                return null;
            }));
    }
    async recovery(user) {
        return await userRef.doc(user.getId()).update({
            auth: user.getAuth()
        }).then(() => {
            return user;
        }).catch(() => {
            return null;
        });
    }
    //Método de Login
    async login(user) {
        return await userRef.doc(user.getId()).update({
            auth: user.getAuth()
        }).then(() => {
            return user.getAuth();
        }).catch(() => {
            return null;
        });
    }
    //Método de Logout
    async logout(user) {
        return userRef.doc(user.getId()).update({
            auth: deleteField
        }).then(() => {
            return 'LOGOUT';
        }).catch(() => {
            return null;
        });
    }
    async find(id) {
        return await userRef.doc(id).get()
            .then((querySnapshot => {
                let user = {};
                user = querySnapshot.data();
                user.id = querySnapshot.id;
                delete user.auth;
                delete user.password;
                return new User(user);
            })).catch((e) => {
                console.log(e);
                return null;
            });
    }
    async findAll(user) {
        return await userRef.where("type", ">", user.getType())
            .get().then((querySnapshot => {
                var users = [];

                querySnapshot.docs.forEach((doc) => {
                    let userDoc = doc.data();
                    delete userDoc.auth;
                    delete userDoc.password;
                    userDoc.id = doc.id;
                    users.push(new User(userDoc).get());
                });
                let owner = user.get();
                delete owner.auth;
                delete owner.password;
                users.push(owner);
                return users;
            })).catch(() => {
                return null;
            });
    }
}

module.exports = new UserRepository();