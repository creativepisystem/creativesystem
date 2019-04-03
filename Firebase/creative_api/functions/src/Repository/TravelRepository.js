const db = require("./../Config/ConnectionDB");
const travelRef = db.collection("travels");

const Travel = require("./../Class/Travel")

class TravelRepository {
    async save(travel) {
        return (await travelRef.add(travel).then((doc) => {
            travel.id = doc.id
            return new Travel(travel);
        }).catch(() => {
            return null;
        }));
    }

    async update(travel) {
        let id = travel.id;
        delete travel.id;
        return (await travelRef.doc(id).update(travel).then(() => {
            return "ok";
        }).catch(() => {
            return null;
        }));
    }
    async find(id) {
        return (await travelRef.doc(id).get()
            .then((querySnapshot => {
                let travel = {};
                travel = querySnapshot.data();
                travel.id = querySnapshot.id;
                return new Travel(travel);
            })).catch((e) => {
                console.log(e);
                return null;
            }));
    }
    async findAll() {
        return (await travelRef.orderBy("date","desc").get().then((querySnapshot => {
                var travels = [];
                querySnapshot.docs.forEach((doc) => {
                    let travelDoc = doc.data();
                    travelDoc.id = doc.id;
                    travels.push(new Travel(travelDoc).get());
                });
                return travels;
            })).catch(() => {
                return null;
            }));
    }
}

module.exports = new TravelRepository();