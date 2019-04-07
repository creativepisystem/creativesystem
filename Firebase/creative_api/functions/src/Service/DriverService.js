const Driver = require("./../Class/Driver");
const driverRepository = require("./../Repository/DriverRepository");

class DriverSevice {
    async saveDriver(driver) {
        return (await driverRepository.save(driver.get()));
    }
    async getById(id) {
        return (await driverRepository.find(id));
    }
    async getAll() {
        return (await driverRepository.findAll());
    }
    async updateDriver(driver){
        return (await driverRepository.update(driver.get()));
    }
    async findByUser(user) {
        return (await driverRepository.findByUser(user.getId()));
    }
}

module.exports = new DriverSevice();