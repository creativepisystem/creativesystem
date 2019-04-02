const db = require("./../Config/ConnectionDB");
const supplyRef = db.collection("supplys");

const Supply = require("./../Class/Supply")

class SupplyRepository {
    async save(supply) {
        return (await supplyRef.add(supply).then((doc) => {
            supply.id = doc.id
            return new Supply(supply);
        }).catch(() => {
            return null;
        }));
    }

    async update(supply) {
        let id = supply.id;
        delete supply.id;
        return (await supplyRef.doc(id).update(supply).then(() => {
            return "ok";
        }).catch(() => {
            return null;
        }));
    }
    async find(id) {
        return (await supplyRef.doc(id).get()
            .then((querySnapshot => {
                let supply = {};
                supply = querySnapshot.data();
                supply.id = querySnapshot.id;
                return new Supply(supply);
            })).catch((e) => {
                console.log(e);
                return null;
            }));
    }
    async findAll() {
        return (await supplyRef.get().then((querySnapshot => {
                var supplys = [];
                querySnapshot.docs.forEach((doc) => {
                    let supplyDoc = doc.data();
                    supplyDoc.id = doc.id;
                    supplys.push(new Supply(supplyDoc).get());
                });
                return supplys;
            })).catch(() => {
                return null;
            }));
    }
}

module.exports = new SupplyRepository();