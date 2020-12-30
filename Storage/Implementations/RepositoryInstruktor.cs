using BrokerClass;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementations
{
    public class RepositoryInstruktor : IRepositoryInstruktor
    {

        private Broker broker = new Broker();

        public bool ObrisiInstruktora(Instruktor instruktor)
        {
            broker.OtvoriKonekciju();
            bool uspelo = broker.ObrisiInstruktora(instruktor);
            broker.ZatvoriKonekciju();
            return uspelo;
        }

        public List<Instruktor> VratiInstruktore(Kategorija? kategorija)
        {
            broker.OtvoriKonekciju();
            List<Instruktor> instruktori = broker.VratiInstruktore(kategorija);
            broker.ZatvoriKonekciju();
            return instruktori;
        }

        public bool UpdateInstruktora(Instruktor instruktor)
        {
            broker.OtvoriKonekciju();
            bool uspelo = broker.UpdateInstruktora(instruktor);
            broker.ZatvoriKonekciju();
            return uspelo;
        }
    }
}
