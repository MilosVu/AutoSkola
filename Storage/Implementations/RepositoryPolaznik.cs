using BrokerClass;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementations
{
    public class RepositoryPolaznik : IRepositoryPolaznik
    {
        private Broker broker = new Broker();

        public bool IzmeniPolaznika(Polaznik polaznik)
        {
            throw new NotImplementedException();
        }

        public bool KreirajPolaznika(Polaznik polaznik)
        {
            broker.OtvoriKonekciju();
            bool uspelo = broker.KreirajPolaznika(polaznik);
            broker.ZatvoriKonekciju();
            return uspelo;
        }

        public bool ObrisiPolaznika(Polaznik polaznik)
        {
            broker.OtvoriKonekciju();
            bool uspelo = broker.ObrisiPolaznika(polaznik);
            broker.ZatvoriKonekciju();
            return uspelo;
        }

        public bool Update(Polaznik polaznik)
        {
            broker.OtvoriKonekciju();
            bool uspelo = broker.Update(polaznik);
            broker.ZatvoriKonekciju();
            return uspelo;
        }

        public Polaznik VratiPolaznika(Polaznik polaznik)
        {
            broker.OtvoriKonekciju();
            Polaznik novPolaznik = broker.VratiPolaznika(polaznik);
            broker.ZatvoriKonekciju();
            return novPolaznik;
        }

        public List<Polaznik> VratiPolaznike()
        {
            broker.OtvoriKonekciju();
            List<Polaznik> polaznici = broker.VratiPolaznike();
            broker.ZatvoriKonekciju();
            return polaznici;
        }

    }
}
