const driverService = require("./../Service/DriverService");
const vehicleService = require("./../Service/VehicleService");
const routeService = require("./../Service/RouteService");
module.exports = {
  create: async (supply, succes, error) => {
    if (
      supply === undefined ||
      supply.date === undefined ||
      supply.driver === undefined ||
      supply.vehicle === undefined ||
      supply.liters === undefined ||
      supply.price === undefined ||
      supply.total === undefined ||
      supply.current_km === undefined
    )
      error();
    else if (new Date(supply.date) > new Date()) error(1);
    else if (supply.price <= 0) error(2);
    else if (supply.liters <= 0) error(3);
    else if (supply.current_km <= 0) error(4);
    else if (supply.total <= 0) error(4);
    else if ((await driverService.getById(supply.driver)) === null) error(5);
    else if ((await vehicleService.getById(supply.vehicle)) === null) error(6);
    else if (
      supply.route !== undefined &&
      (await routeService.getById(supply.route)) === null
    ) {
      error(7);
    } else if (
      supply.station !== undefined &&
      (supply.station.length < 2 || supply.station.length > 30)
    ) {
      error(8);
    } else succes();
  },
  update: async (supply, succes, error) => {
    if (supply === undefined) error();
    else if (supply.date !== undefined && new Date(supply.date) > new Date())
      error();
    else if (supply.price !== undefined && supply.price <= 0) error();
    else if (supply.lites !== undefined && supply.liters <= 0) error();
    else if (supply.current_km !== undefined && supply.current_km <= 0) error();
    else if (supply.total !== undefined && supply.total <= 0) error();
    else if (
      supply.driver !== undefined &&
      (await driverService.getById(supply.driver)) === null
    )
      error();
    else if (
      supply.vehicle !== undefined &&
      (await vehicleService.getById(supply.vehicle)) === null
    )
      error();
    else if (
      supply.route !== undefined &&
      (await routeService.getById(supply.route)) === null
    )
      error();
    else if (
      supply.station !== undefined &&
      (supply.station.length < 2 || supply.station.length > 30)
    )
      error();
    else succes();
  }
};
