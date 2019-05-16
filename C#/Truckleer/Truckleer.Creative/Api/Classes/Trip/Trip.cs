using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Truckleer.Api.Classes
{
    public class Trip
    {
        public Trip()
        {
        }

        private string Id { get; set; }
        private DateTime Date { get; set; }
        private string Name { get; set; }
        private Route Route { get; set; }
        private Driver Driver { get; set; }
        private bool Status { get; set; }
        private Vehicle Vehicle { get; set; }
    }
}
