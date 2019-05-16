using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
    public class Route
    {
        //Constructor
        public Route()
        {
        }

        //Atributes
        private string Id { get; set; }
        private string Origin { get; set; }
        private string Destination { get; set; }
        private List <string> Stops { get; set; }
    }
}
