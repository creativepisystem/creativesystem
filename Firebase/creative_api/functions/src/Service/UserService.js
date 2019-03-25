/*****************************************************************************************
 * O UserService trata as regras de négocio para Usuarios,todo service é chamado por um 
 * controller ou seja não há uma rota HTTP direta para ele.
 * O UserService Importa o userRepository,classe responsavel por consulta no banco e trativa
 * de dados.
 *****************************************************************************************/
// Importação do UserRepository
const userRepository = require("./../Repository/UserRepository")
const hash = require("./../utils/AuthGenerator");
const emailSender = require("./../utils/EmailSender");
const email = require("./../Enum/EmailEnum");
const User = require("./../Class/User")
// Declaração da classe UserService
class UserService {
    // Método de Criação do Usuario
    async saveUser(user) {
        /*
            No Banco de Dados não pode haver dois usuarios iguais,
            a senha e usuario deve conter no minimo 6 e no maximo
            30 Caracteres
        */
        return userRepository.save(user);
    }
    async updateUser(user) {
        //terminar de implementa Criar Usuario
        let updateUser = new User();
        updateUser.setId(user.user.getId());
        if(user.newUser.email != undefined && user.newUser.email != null)
            updateUser.setEmail(user.newUser.email);
        if(user.newUser.password != undefined && user.newUser.password != null)
            updateUser.setPassword(user.newUser.password);
        return userRepository.update(updateUser);
    }
    async recoveryUser(user,success,error){
        user.setAuth(hash.generate(40));
        let res = await userRepository.recovery(user);
        if(res == null)
            return null;
        else{
           return await emailSender(res.getEmail(),email.RECOVERY,res,success,error);
        }
    }
    //Método de Login
    async login(user) {
        let userAuth = await userRepository.findByUserAndPass(user);
        if(userAuth === null){
            return null;
        }
        if(userAuth.getAuth() !== undefined){
            return userAuth.getAuth();
        }
        userAuth.setAuth(hash.generate(20));
        if(userAuth.getId() === undefined)
            return null
        return userRepository.login(userAuth);
    }
    //Método de Logout
    logout(user) {
        return userRepository.logout(user);
    }
    //Método de Validação do Token de autenticação
    isValidPermission(user) {
        return userRepository.findByUserAndAuth(user);
    }
    async findUser(user){
        return await userRepository.findByUser(user)
    }
    async find(user,id){
        let findUser = await userRepository.find(id);
        if(findUser.getType() > user.getType())
            return findUser;
        else
            return null;
    }
    async findAll(user){

        return await userRepository.findAll(user);
    }
}
module.exports = new UserService();