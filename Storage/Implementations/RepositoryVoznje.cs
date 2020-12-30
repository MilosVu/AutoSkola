using BrokerClass;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementations
{
    public class RepositoryVoznje : IRepositoryVoznje
    {
        
        private Broker broker = new Broker();

        public bool KreirajVoznju(Voznja voznja)
        {
            broker.OtvoriKonekciju();
            bool uspelo = broker.KreirajVoznju(voznja);
            broker.ZatvoriKonekciju();
            return uspelo;
        }
        
        public List<Voznja> VratiVoznje(Kategorija? kategorija)
        {
            broker.OtvoriKonekciju();
            List<Voznja> voznje = broker.VratiVoznje(kategorija);
            broker.ZatvoriKonekciju();
            return voznje;
        }
    }
}
