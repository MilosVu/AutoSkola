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
            throw new NotImplementedException();
        }
        
        public List<Voznja> VratiVoznje()
        {
            broker.OtvoriKonekciju();
            List<Voznja> voznje = broker.VratiVoznje();
            broker.ZatvoriKonekciju();
            return voznje;
        }
    }
}
