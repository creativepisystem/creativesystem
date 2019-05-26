using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    public class SupplyFilter:IFilter<Supply>
    {
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public Trip Trip { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public Route Route { get; set; }

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
