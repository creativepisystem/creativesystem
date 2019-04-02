class Supply {
  constructor(object = null) {
    if (object != null) {
      this.supply = {
        id: object.id,
        date: object.date,
        driver: object.driver,
        vehicle: object.vehicle,
        route: object.route,
        liters: object.liters,
        total: object.total,
        current_km: object.current_km,
        station: object.station,
        price: object.price
      };
      Object.keys(this.supply).forEach(k => {
        if (this.supply[k] === undefined || this.supply[k] === null)
          delete this.supply[k];
      });
    } else {
      this.supply = {};
    }
  }

  get() {
    return this.supply;
  }
  set(supply) {
    Object.keys(supply).forEach(k => {
      if (supply[k] === undefined || supply[k] === null) delete supply[k];
    });
    this.supply = supply;
  }
  getId() {
    return this.supply.id;
  }
  setId(id) {
    this.supply.id = id;
  }
  getPrice() {
    return this.supply.price;
  }
  setPrice(price) {
    this.supply.price = price;
  }
  getDate() {
    return supply.date;
  }
  setDate(date) {
    supply.date = date;
  }
  getDriver() {
    return supply.driver;
  }
  setDriver(driver) {
    supply.driver = driver;
  }
  getVehicle() {
    return supply.vehicle;
  }
  setVehicle(vehicle) {
    supply.vehicle = vehicle;
  }
  getRoute() {
    return supply.route;
  }
  setRoute(route) {
    supply.route = route;
  }
  getLiters() {
    return supply.liters;
  }
  setLiters(liters) {
    supply.liters = liters;
  }
  getTotal() {
    return supply.total;
  }
  setTotal(total) {
    supply.total = total;
  }
  getCurrent_km() {
    return supply.current_km;
  }
  setCurrent_km(current_km) {
    supply.current_km = current_km;
  }
  getStation() {
    return supply.station;
  }
  setStation(station) {
    supply.station = station;
  }
}
module.exports = Supply;