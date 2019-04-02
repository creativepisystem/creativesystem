const userService = require('../Service/UserService');
module.exports = {
    create: async function (user, newUser) {
        if (newUser.user === undefined || newUser.password === undefined ||
            newUser.type === undefined || newUser.email === undefined)
            return true;
        if (newUser.user.length < 5 || newUser.password.length < 5 ||
            newUser.user.length > 30 || newUser.password.length > 30)
            return true;
        if (newUser.type < 1 || newUser.type > 3)
            return true;
        if (!/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
            .test(newUser.email))
            return true;
        if (user.get() === null)
            return true;
        if (user.getType() >= newUser.type)
            return true;
        if (await userService.findUser(newUser.user) != null)
            return true;
        return false;
    },
    update: function (user) {
        if ((user.password == undefined || user.password == null) && (user.email == undefined || user.email == null))
            return true
        if (user.password !== undefined && user.password != null) {
            if (user.password.length < 5 || user.password.length > 30)
                return true;
        }
        if (user.email !== undefined && user.email != null) {
            if (!/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
                .test(user.email))
                return true;
        }
        return false;
    },
    auth: async function (user, sucess, error) {
        
        if (user.user !== undefined && user.auth !== undefined) {
            let validUser = (await userService.isValidPermission(user));
            if (validUser == null)
                error();
            else if (validUser.get() !== null)
                sucess(validUser);
            else
                error();
        } else
            error();
    }
}