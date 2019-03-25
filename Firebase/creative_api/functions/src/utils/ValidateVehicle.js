const vehicleService = require('./../Service/VehicleService');
module.exports = {
    create: async function (vehicle,success,error) {
        if(vehicle.license_plate === undefined || vehicle.tank_capacity === undefined)
            error();
        else if(vehicle.license_plate.length < 7 || vehicle.license_plate.length > 8)
            error();
        else if(vehicle.tank_capacity <= 0)
            error();
        else if( (await vehicleService.findByLincensePlate(vehicle.license_plate)) != null)
            error();
        else
            success();
    }
} 