const userService = require("./../Service/UserService");
const driverService = require("./../Service/DriverService");
const travelService = require("./../Service/TravelService");
const routeService = require("./../Service/RouteService");
const vehicleService = require("./../Service/VehicleService");
const Config = require("./../Class/Config");
const Driver = require("./../Class/Driver");
class DeviceService {
  async login(user) {
    return await userService.loginDevice(user);
  }
  async getConfig(user) {
    let driver = (await driverService.findByUser(user));
    if (driver == null) return null;
    driver = new Driver({
        id: driver.getId(),
        name: driver.getName()
    });
    let travels = (await travelService.findByDriver(driver));
    if (travels == null) travels = [];
    let routes = (await routeService.getAll());
    if (routes == null) routes = [];
    let vehicles = (await vehicleService.getAll());
    if (vehicles == null) vehicles = [];
    return new Config({
        drivers : driver.get(),
        travels: travels,
        routes : routes,
        vehicles: vehicles
    });
  }
}

module.exports = new DeviceService();
