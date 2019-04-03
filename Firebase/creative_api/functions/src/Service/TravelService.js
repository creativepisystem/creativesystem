const Travel = require("./../Class/Travel");
const travelRepository = require("./../Repository/TravelRepository");

class TravelSevice {
    async saveTravel(travel) {
        return (await travelRepository.save(travel.get()));
    }
    async getById(id) {
        return (await travelRepository.find(id));
    }
    async getAll() {
        return (await travelRepository.findAll());
    }
    async updateTravel(travel){
        return (await travelRepository.update(travel.get()));
    }
}

module.exports = new TravelSevice();