using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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

        IFirebaseClient client;

        private void FirebaseClient()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {

            }
        }
        
    }
}
