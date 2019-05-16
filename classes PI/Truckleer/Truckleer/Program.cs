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
                    id = "eySPZJGHlI2d4EHaPaA4"
                }

            };

            List<Supply> result = supplyFilter.Filter();

            Console.WriteLine(result.Count);

            Console.ReadKey();
        }
    }
}
