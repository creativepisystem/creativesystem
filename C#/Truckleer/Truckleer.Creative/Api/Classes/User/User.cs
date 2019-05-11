using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
    class User
    {
        //Constructor
        public User()
        {
        }

        //Artributes
        private string Id { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private UserType Type { get; set; }
        private string Auth { get; set; }
        private string Email { get; set; }
    }
}
