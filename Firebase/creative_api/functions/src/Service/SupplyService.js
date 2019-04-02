const Supply = require("./../Class/Supply");
const supplyRepository = require("./../Repository/SupplyRepository");

class SupplySevice {
    async saveSupply(supply) {
        return (await supplyRepository.save(supply.get()));
    }
    async getById(id) {
        return (await supplyRepository.find(id));
    }
    async getAll() {
        return (await supplyRepository.findAll());
    }
    async updateSupply(supply){
        return (await supplyRepository.update(supply.get()));
    }
}

module.exports = new SupplySevice();