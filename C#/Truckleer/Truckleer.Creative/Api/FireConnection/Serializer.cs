using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.FireConnection.Serializer
{
    class Serializer<T>
    {
        static FireConnection Conn = new FireConnection();

        public string Path { get; set; }

        public Serializer(string Path)
        {
            this.Path = Path;
        }

        public T FindById()
        {
            return Conn.Client.Get("/supplys/3ooEqZuHW7A5UpxgMYUu/").ResultAs<T>();
        }
    }
}
