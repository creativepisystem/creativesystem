const driverService = require("./../Service/DriverService");
const vehicleService = require("./../Service/VehicleService");
const routeService = require("./../Service/RouteService");
const status = require("./../Enum/StatusEnum");
module.exports = {
  create: async (travel, succes, error) => {
    if (
      travel === undefined ||
      travel.date === undefined ||
      travel.name === undefined ||
      travel.driver === undefined ||
      travel.vehicle === undefined
    )
      error();
    else if (new Date(travel.date) > new Date()) error();
    else if (travel.name.length < 3 || travel.name.length > 30) error();
    else if (
      travel.route !== undefined &&
      (await routeService.getById(travel.route)) === null
    )
      error();
    else if (
      travel.driver !== undefined &&
      (await driverService.getById(travel.driver)) === null
    )
      error();
    else if ((await vehicleService.getById(travel.vehicle)) === null) error();
    else succes();
  },
  update: async (travel, succes, error) => {
    if (travel === undefined) error();
    else if (travel.date !== undefined && new Date(travel.date) > new Date())
      error();
    else if (
      travel.name !== undefined &&
      (travel.name.length < 2 || travel.name.length > 30)
    )
      error();
    else if (
      travel.status !== undefined &&
      travel.status != status.open &&
      travel.status != status.finish
    )
      error();
    else if (
      travel.driver !== undefined &&
      (await driverService.getById(travel.driver)) === null
    )
      error();
    else if (
      travel.route !== undefined &&
      (await routeService.getById(travel.route)) === null
    )
      error();
    else if (
      travel.vehicle !== undefined &&
      (await vehicleService.getById(travel.vehicle)) === null
    )
      error();
    else succes();
  }
};
