using System.Collections.Generic;

namespace Truckleer.Modules
{
    public class VehicleFilter:IFilter<Vehicle>
    {
        readonly private VehicleService vehicleService;
        public string LicensePlate { get; set; }
        public VehicleFilter()
        {
            vehicleService = new VehicleService();
        }

        public List<Vehicle> Filter()
        {
            return null;//vehicleService.Filter(this);
        }
    }
}
