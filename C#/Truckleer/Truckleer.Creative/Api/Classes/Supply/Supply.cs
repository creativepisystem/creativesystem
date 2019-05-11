using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Truckleer.Api.Classes
{
    class Supply
    {
        public Supply()
        {
        }

        public string Id { get; set; }
        public DateTime Date { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public Route Route { get; set; }
        public float Liters { get; set; }
        public decimal Total { get; set; }
        public float Current_Km { get; set; }
        public string Station { get; set; }
        public decimal Price { get; set; }
        public Trip Trip { get; set; }
    }
}
