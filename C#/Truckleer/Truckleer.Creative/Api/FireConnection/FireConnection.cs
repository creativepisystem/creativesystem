using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Truckleer.Api.Classes;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.FireConnection
{
    class FireConnection
    {
        readonly IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bs4keWmPRssX4EEigZ5cgpHNkRkxcPNtLuc6xlIb",
            BasePath = "https://creative-external-supply.firebaseio.com"
        };

        public IFirebaseClient Client;

        public FireConnection()
        {
            Client = new FireSharp.FirebaseClient(config);
        }
        
    }
}
