using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
    class Driver
    {
        //Constructor
        public Driver()
        {
        }

        //Path Of Vehicle On Firebase
        public const string Path = "driver";

        //Atributes
        public string Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public int Cnh_number { get; set; }
        public DateTime Bith_date { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public DateTime Cnh_expiration { get; set; }
        public string Photo { get; set; }
        public string Obs { get; set; }
        public User User { get; set; }
    }

}
