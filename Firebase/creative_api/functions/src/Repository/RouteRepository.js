const db = require("./../Config/ConnectionDB");
const routeRef = db.collection("routes");

const Route = require("./../Class/Route")

class RouteRepository {
    async save(route) {
        return (await routeRef.add(route).then((doc) => {
            route.id = doc.id
            return new Route(route);
        }).catch(() => {
            return null;
        }));
    }

    async update(route) {
        let id = route.id;
        delete route.id;
        return (await routeRef.doc(id).update(route).then(() => {
            return "ok";
        }).catch(() => {
            return null;
        }));
    }
    async find(id) {
        return (await routeRef.doc(id).get()
            .then((querySnapshot => {
                let route = {};
                route = querySnapshot.data();
                route.id = querySnapshot.id;
                return new Route(route);
            })).catch((e) => {
                console.log(e);
                return null;
            }));
    }
    async findAll() {
        return (await routeRef.get().then((querySnapshot => {
                var routes = [];
                querySnapshot.docs.forEach((doc) => {
                    let routeDoc = doc.data();
                    routeDoc.id = doc.id;
                    routes.push(new Route(routeDoc).get());
                });
                return routes;
            })).catch(() => {
                return null;
            }));
    }
}

module.exports = new RouteRepository();