class Supply {
    constructor(object = null) {
      if (object != null) {
        this.supply = {
          id: object.id,
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
  }
  module.exports = Supply;
  