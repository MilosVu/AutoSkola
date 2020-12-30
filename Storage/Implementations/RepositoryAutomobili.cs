using BrokerClass;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementations
{
    public class RepositoryAutomobili : IRepositoryAutomobili
    {

        Broker broker = new Broker();

        public List<Automobil> VratiAutomobile(Kategorija? kategorija)
        {
            broker.OtvoriKonekciju();
            List<Automobil> automobili =  broker.VratiAutomobile(kategorija);
            broker.ZatvoriKonekciju();
            return automobili;
        }
    }
}
