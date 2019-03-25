const db = require("./../Config/ConnectionDB");
const vehiclesRef = db.collection("vehicles");
const Vehicle = require("./../Class/Vehicle");

class VehicleRepository{
    save(vehicle) {
        return vehiclesRef.add(vehicle).then((doc) => {
            vehicle.id = doc.id
            return new Vehicle(vehicle);
        }).catch(() => {
            return null;
        });
    }
    
    async findByLincensePlate(license_plate) {
        return await vehiclesRef.where("license_plate", "==", license_plate).get().then((querySnapshot => {
            if (querySnapshot.docs.length != 1) {
                return null;
            }
            vehicle = querySnapshot.docs[0].data();
            vehicle.id = querySnapshot.docs[0].id
            return new Vehicle(vehicle);
        })).catch(() => {
            return null;
        });
    }
}

module.exports = new VehicleRepository();