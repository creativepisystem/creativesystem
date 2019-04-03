class Travel {
  constructor(object = null) {
    if (object != null) {
      this.travel = {
        id: object.id,
        date: object.date,
        name: object.name,
        route: object.route,
        driver: object.driver,
        status: object.status,
        vehicle: object.vehicle
      };
      Object.keys(this.travel).forEach(k => {
        if (this.travel[k] === undefined || this.travel[k] === null)
          delete this.travel[k];
      });
    } else {
      this.travel = {};
    }
  }

  get() {
    return this.travel;
  }
  set(travel) {
    Object.keys(travel).forEach(k => {
      if (travel[k] === undefined || travel[k] === null) delete travel[k];
    });
    this.travel = travel;
  }
  getId() {
    return this.travel.id;
  }
  setId(id) {
    this.travel.id = id;
  }
  getVehicle() {
    return this.travel.vehicle;
  }
  setVehicle(vehicle) {
    this.travel.vehicle = vehicle;
  }
  getStatus() {
    return this.travel.status;
  }
  setStatus(status) {
    this.travel.status = status;
  }
  getDate() {
    return this.travel.date;
  }
  setDate(date) {
    this.travel.date = date;
  }
  getName() {
    return this.travel.name;
  }
  setName(name) {
    this.travel.name = name;
  }
  getRoute() {
    return this.travel.route;
  }
  setRoute(route) {
    this.travel.route = route;
  }

  getDriver() {
    return this.travel.driver;
  }
  setDriver(driver) {
    this.travel.driver = driver;
  }
}
module.exports = Travel;
