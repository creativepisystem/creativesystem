const Vehicle = require("./../Class/Vehicle");
const vehicleRepository = require("./../Repository/VehicleRepository");

class VehicleSevice {
    async saveVehicle(vehicle) {
        return (await vehicleRepository.save(vehicle.get()));
    }
    async getById(id) {
        return (await vehicleRepository.find(id));
    }
    async getAll() {
        return (await vehicleRepository.findAll());
    }
    async updateVehicle(vehicle){
        return (await vehicleRepository.update(vehicle.get()));
    }
    async findByLicensePlate(license_plate) {
        return (await vehicleRepository.findByLicensePlate(license_plate));
    }
}

module.exports = new VehicleSevice();