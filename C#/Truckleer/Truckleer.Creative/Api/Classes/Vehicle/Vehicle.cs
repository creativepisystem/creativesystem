using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
    class Vehicle
    {
        public Vehicle()
        {

        }

        private string Id { get; set; }
        private string License_Plate { get; set; }
        private string Model { get; set; }
        private string Brand { get; set; }
        private int Tank_Capacity { get; set; }
        private DateTime Fab_Year { get; set; }
        private DateTime Mod_Year { get; set; }
        private string Color { get; set; }
        private int Renavam { get; set; }
        private string Chassi { get; set; }
    }
}
