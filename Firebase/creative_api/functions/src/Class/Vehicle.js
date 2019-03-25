class Vehicle {
    constructor(object = null) {
        if (object != null) {
            this.vehicle = {
                id: object.id,
                license_plate: object.license_plate,
                model: object.model,
                brand: object.brand,
                tank_capacity: object.tank_capacity,
            }
            Object.keys(this.vehicle).forEach(k => {
                if (this.vehicle[k] === undefined || this.vehicle[k] === null)
                    delete this.vehicle[k];
            });
        }else{
            this.vehicle={};
        }
    };
    get() {
        return this.vehicle;
    }
    set(vehicle) {
        Object.keys(vehicle).forEach(k => {
            if (vehicle[k] === undefined || vehicle[k] === null)
                delete vehicle[k];
        });
        this.vehicle = vehicle;
    }
    getLicensePlate() {
        return this.vehicle.license_plate;
    }
    setLicensePlate(license_plate) {
        this.vehicle.license_plate = license_plate;
    }
    getBrand() {
        return this.vehicle.brand;
    }
    setBrand(brand) {
        this.vehicle.brand = brand;
    }
    getModel() {
        return this.vehicle.model;
    }
    setModel(model) {
        this.vehicle.model = model;
    }
    getId() {
        return this.vehicle.id;
    }
    setId(id) {
        this.vehicle.id = id;
    }
    getTankCapacity() {
        return this.vehicle.tank_capacity;
    }
    setTankCapacity(tank_capacity) {
        this.vehicle.tank_capacity = tank_capacity;
    }
}
module.exports = Vehicle;