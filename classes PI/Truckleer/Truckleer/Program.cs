using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truckleer.Modules;
namespace Truckleer
{
    class Program
    {
        static void Main(string[] args)
        {

            SupplyFilter supplyFilter = new SupplyFilter()
            {
                driver = new Driver()
                {
                    Id = "eySPZJGHlI2d4EHaPaA4"
                },
                vehicle = new Vehicle()
                {
                    id = "qhLN3PhDdxi1BukZLiSU"
                },
                route = new Route()
                {
                    Id = "lAmH6BGm8lUjRk06vEoP"
                },

            };

            List<Supply> result = supplyFilter.Filter();

            Console.ReadKey();
        }
    }
}
