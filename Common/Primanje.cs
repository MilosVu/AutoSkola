using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Primanje
    {

        private readonly Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Primanje(Socket socket)
        {
            this.socket = socket;
            this.stream = new NetworkStream(socket);
            this.formatter = new BinaryFormatter();
        }

        public object Primi()
        {
            return formatter.Deserialize(stream);
        }

    }
}
