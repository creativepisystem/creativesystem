module.exports = function(user){
    let secureUser = user.get();
    delete secureUser.auth;
    delete secureUser.password;
    return secureUser;
}