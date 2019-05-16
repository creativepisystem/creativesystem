using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    public class SupplyFilter:IFilter<Supply>
    {
        public DateTime startAt { get; set; }
        public DateTime endAt { get; set; }
        public Trip trip { get; set; }
        public Driver driver { get; set; }
        public Vehicle vehicle { get; set; }
        public Route route { get; set; }

        private readonly SupplyService supplyService;
        public SupplyFilter(){
            supplyService = new SupplyService();
        }

        public List<Supply> Filter()
        { 
            return supplyService.Filter(this);
        }
    }
}
