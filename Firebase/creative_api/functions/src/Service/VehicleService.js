const Vehicle = require("./../Class/Vehicle");
const vehicleRepository = require("./../Repository/VehicleRepository");

class VehicleSevice {
    async saveVehicle(vehicle) {
        return await vehicleRepository.save(vehicle);
    }

    async findByLincensePlate(license_plate) {
        return await vehicleRepository.findByLincensePlate(license_plate);
    }
}

module.exports = new VehicleSevice();