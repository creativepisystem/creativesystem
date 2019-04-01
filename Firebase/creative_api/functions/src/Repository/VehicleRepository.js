const db = require("./../Config/ConnectionDB");
const vehicleRef = db.collection("vehicles");

const Vehicle = require("./../Class/Vehicle")

class VehicleRepository {
    async save(vehicle) {
        return (await vehicleRef.add(vehicle).then((doc) => {
            vehicle.id = doc.id
            return new Vehicle(vehicle);
        }).catch(() => {
            return null;
        }));
    }

    async update(vehicle) {
        let id = vehicle.id;
        delete vehicle.id;
        return (await vehicleRef.doc(id).update(vehicle).then(() => {
            return "ok";
        }).catch(() => {
            return null;
        }));
    }
    async find(id) {
        return (await vehicleRef.doc(id).get()
            .then((querySnapshot => {
                let vehicle = {};
                vehicle = querySnapshot.data();
                vehicle.id = querySnapshot.id;
                return new Vehicle(vehicle);
            })).catch((e) => {
                console.log(e);
                return null;
            }));
    }
    async findAll() {
        return (await vehicleRef.get().then((querySnapshot => {
                var vehicles = [];
                querySnapshot.docs.forEach((doc) => {
                    let vehicleDoc = doc.data();
                    vehicleDoc.id = doc.id;
                    vehicles.push(new Vehicle(vehicleDoc).get());
                });
                return vehicles;
            })).catch(() => {
                return null;
            }));
    }

    async findByLicensePlate(license_plate) {
        return (await vehicleRef.where("license_plate", "==", license_plate).get().then((querySnapshot => {
            console.log(querySnapshot.docs.length);
            if (querySnapshot.docs.length >= 1) {
                return null;
            }
            return new Vehicle({});
        })).catch(() => {
            return null;
        }));
    }
}

module.exports = new VehicleRepository();