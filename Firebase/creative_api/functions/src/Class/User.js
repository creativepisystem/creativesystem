class User {
    constructor(object = null) {
        if (object != null) {
            this.user = {
                id: object.id,
                user: object.user,
                password: object.password,
                type: object.type,
                driver: object.driver,
                auth : object.auth,
                email: object.email
            }
            Object.keys(this.user).forEach(k => {
                if (this.user[k] === undefined || this.user[k] === null)
                    delete this.user[k];
            });
        }else{
            this.user={};
        }
    };
    get() {
        return this.user;
    }
    set(user) {
        Object.keys(user).forEach(k => {
            if (user[k] === undefined || user[k] === null)
                delete user[k];
        });
        this.user = user;
    }
    getAuth() {
        return this.user.auth;
    }
    setAuth(auth) {
        this.user.auth = auth;
    }
    getUser() {
        return this.user.user;
    }
    setUser(user) {
        this.user.user = user;
    }
    getPassword() {
        return this.user.password;
    }
    setPassword(password) {
        this.user.password = password;
    }
    getType() {
        return this.user.type;
    }
    setType(type) {
        this.user.type = type;
    }
    getId() {
        return this.user.id;
    }
    setId(id) {
        this.user.id = id;
    }
    getDriver() {
        return this.user.driver;
    }
    setDriver(driver) {
        this.user.driver = driver;
    }

    getEmail() {
        return this.user.email;
    }
    setEmail(email) {
        this.user.email = email;
    }
}
module.exports = User;