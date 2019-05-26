using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules.CustomConvert
{
    class CustomUserConvert : IFirestoreConverter<User>
    {
        public User FromFirestore(object value)
        {
            return new UserService().FindOne(Convert.ToString(value));
        }

        public object ToFirestore(User value) => value.Id;
    }
}
