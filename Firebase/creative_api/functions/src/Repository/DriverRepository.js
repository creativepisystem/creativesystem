const db = require("./../Config/ConnectionDB");
const driverRef = db.collection("drivers");

const Driver = require("./../Class/Driver")

class DriverRepository {
    async save(driver) {
        return (await driverRef.add(driver).then((doc) => {
            driver.id = doc.id
            return new Driver(driver);
        }).catch(() => {
            return null;
        }));
    }

    async update(driver) {
        let id = driver.id;
        delete driver.id;
        return (await driverRef.doc(id).update(driver).then(() => {
            return "ok";
        }).catch(() => {
            return null;
        }));
    }
    async find(id) {
        return (await driverRef.doc(id).get()
            .then((querySnapshot => {
                let driver = {};
                driver = querySnapshot.data();
                driver.id = querySnapshot.id;
                return new Driver(driver);
            })).catch((e) => {
                console.log(e);
                return null;
            }));
    }
    async findAll() {
        return (await driverRef.get().then((querySnapshot => {
                var drivers = [];
                querySnapshot.docs.forEach((doc) => {
                    let driverDoc = doc.data();
                    driverDoc.id = doc.id;
                    drivers.push(new Driver(driverDoc).get());
                });
                return drivers;
            })).catch(() => {
                return null;
            }));
    }
}

module.exports = new DriverRepository();