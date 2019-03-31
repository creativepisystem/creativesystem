const Route = require("./../Class/Route");
const routeRepository = require("./../Repository/RouteRepository");

class RouteSevice {
    async saveRoute(route) {
        return (await routeRepository.save(route.get()));
    }
    async getById(id) {
        return (await routeRepository.find(id));
    }
    async getAll() {
        return (await routeRepository.findAll());
    }
    async updateRoute(route){
        return (await routeRepository.update(route.get()));
    }
}

module.exports = new RouteSevice();