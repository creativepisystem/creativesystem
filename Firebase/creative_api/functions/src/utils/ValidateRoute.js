module.exports = {
  create: async (route, succes, error) => {
    if (
      route === undefined ||
      route.origin === undefined ||
      route.destination === undefined ||
      route.stops === undefined
    )
      error();
    else if (route.origin.length < 3 || route.origin.length > 100) error();
    else if (route.destination.length < 3 || route.destination.length > 100)
      error();
    else if (!route.stops instanceof Array) error();
    else if (route.stops.length == 0) error();
    else {
      let validate = true;
      route.stops.forEach(s => {
        if (s.length < 3 || s.length > 100) {
          validate = false;
          error();
          return;
        }
      });
      if (validate) {
        succes();
      }
    }
  },
  update: async (route, succes, error) => {
    if (route === undefined) error();
    else if (
      route.origin !== undefined &&
      (route.origin.length < 3 || route.origin.length > 100)
    )
      error();
    else if (
      route.destination !== undefined &&
      (route.destination.length < 3 || route.destination.length > 100)
    )
      error();
    else if (route.stops !== undefined && !route.stops instanceof Array)
      error();
    else if (route.stops !== undefined && route.stops.length == 0) error();
    else {
      let validate = true;
      if (route.stops !== undefined) {
        route.stops.forEach(s => {
          if (s.length < 3 || s.length > 100) {
            validate = false;
            error();
            return;
          }
        });
      }
      if (validate) {
        succes();
      }
    }
  }
};
