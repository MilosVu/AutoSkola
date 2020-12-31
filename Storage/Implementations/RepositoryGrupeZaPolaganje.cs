using BrokerClass;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementations
{
    public class RepositoryGrupeZaPolaganje : IRepositoryGrupeZaPolaganje
    {

        private Broker broker = new Broker();

        public bool KreirajGrupuZaPolaganje(List<Polaznik> polaznici)
        {
            broker.OtvoriKonekciju();
            bool uspelo = broker.KreirajGrupuZaPolaganje);
            broker.ZatvoriKonekciju();
            return uspelo;
        }

        public List<GrupaZaPolaganje> VratiGrupeZaPolaganje()
        {
            throw new NotImplementedException();
        }
    }
}
