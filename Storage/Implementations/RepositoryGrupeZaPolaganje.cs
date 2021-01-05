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

        public bool KreirajGrupuZaPolaganje(List<Polaznik> polaznici, GrupaZaPolaganje grupaZaPolaganje)
        {
            try
            {

                broker.OtvoriKonekciju();
                broker.ZapocniTransakciju();
                int id = broker.KreirajGrupuZaPolaganje(grupaZaPolaganje);
                foreach (Polaznik p in polaznici)
                {
                    broker.KreirajPolaznikaIGrupuZaPolaganje(p, id);
                }
                broker.Commit();
                return true;
            }
            catch (Exception)
            {
                broker.Rollback();
                return false;
            }
            finally{
                broker.ZatvoriKonekciju();
            }
        }

        public List<GrupaZaPolaganje> VratiGrupeZaPolaganje()
        {
            broker.OtvoriKonekciju();
            List<GrupaZaPolaganje> grupeZaPolaganje = broker.VratiGrupeZaPolaganje();
            broker.ZatvoriKonekciju();
            return grupeZaPolaganje;
        }

        public List<Polaznik> VratiPolaznikaIGrupeZaPolaganje(int idGrupeZaPolaganje)
        {
            broker.OtvoriKonekciju();
            List<Polaznik> polaznici = broker.VratiPolaznikaIGrupeZaPolaganje(idGrupeZaPolaganje);
            broker.ZatvoriKonekciju();
            return polaznici;
        }
    }
}
