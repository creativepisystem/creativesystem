using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class TripFilter : IFilter<Trip>
    {
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public Route Route { get; set; }
        public TripStatus TripStatus { get; set; }
        private readonly TripService tripService;
        public TripFilter()
        {
            tripService = new TripService();
        }
        public List<Trip> Filter()
        {
            return new List<Trip>();//tripService.Filter(this);
        }
    }
}
