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
            DriverService service = new DriverService();

            Driver d = service.FindOne("Zyh5fy3SMfu7mDrkpNWr");
            Console.WriteLine(d.user.user);

            Console.ReadKey();
        }
    }
}
