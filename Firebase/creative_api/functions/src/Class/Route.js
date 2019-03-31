class Route {
    constructor(object = null) {
      if (object != null) {
        this.route = {
          id: object.id,
          origin: object.origin,
          destination: object.destination,
          stops: object.stops
        };
        Object.keys(this.route).forEach(k => {
          if (this.route[k] === undefined || this.route[k] === null)
            delete this.route[k];
        });
      } else {
        this.route = {};
      }
    }
  
    get() {
      return this.route;
    }
    set(route) {
      Object.keys(route).forEach(k => {
        if (route[k] === undefined || route[k] === null) delete route[k];
      });
      this.route = route;
    }
    getId() {
      return this.route.id;
    }
    setId(id) {
      this.route.id = id;
    }
    getOrigin() {
      return this.route.origin;
    }
    setOrigin(origin) {
      this.route.origin = origin;
    }
    getDestination() {
      return this.route.destination;
    }
    setDestination(destination) {
      this.route.destination = destination;
    }
    getStops() {
      return this.route.stops;
    }
    setStops(stops) {
      this.route.stops = stops;
    }
  }
  module.exports = Route;
  