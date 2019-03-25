const createHash = require('hash-generator');
class AuthGenerator{
    constructor(){}
    generate(number){
        return createHash(number);
    }
}
module.exports = new AuthGenerator();