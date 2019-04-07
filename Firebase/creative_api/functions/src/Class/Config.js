class Config {
    constructor(object = null) {
      if (object != null) {
        this.config = {
          drivers: object.drivers,
          routes: object.routes,
          vehicles: object.vehicles,
          travels: object.travels
        };
        Object.keys(this.config).forEach(k => {
          if (this.config[k] === undefined || this.config[k] === null)
            delete this.config[k];
        });
      } else {
        this.config = {};
      }
    }
  
    get() {
      return this.config;
    }
    set(config) {
      Object.keys(config).forEach(k => {
        if (config[k] === undefined || config[k] === null) delete config[k];
      });
      this.config = config;
    }
    getDrivers() {
      return this.config.drivers;
    }
    setDrivers(drivers) {
      this.config.drivers = drivers;
    }
    getRoutes() {
      return this.config.routes;
    }
    setRoutes(routes) {
      this.config.routes = routes;
    }
    getVehicles() {
      return this.config.vehicles;
    }
    setVehicles(vehicles) {
      this.config.vehicles = vehicles;
    }
    getTravels() {
      return this.config.travels;
    }
    setTravels(travels) {
      this.config.travels = travels;
    }
  }
module.exports = Config;
  