using Domain;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Implementations;
using System.ComponentModel;

namespace ControllerClass
{
    public class Controller
    {

        private static Controller instance;

        private Controller() 
        {
            this.repositorySluzbenikAutoSkole = new RepositorySluzbenikAutoSkole(); 
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }

        private IRepositorySluzbenikAutoSkole repositorySluzbenikAutoSkole;
        private IRepositoryPolaznik repositoryPolaznik = new RepositoryPolaznik();
        private IRepositoryInstruktor repositoryInstruktor = new RepositoryInstruktor();
        private IRepositoryVoznje repositoryVoznje = new RepositoryVoznje();
        private IRepositoryAutomobili repositoryAutomobili = new RepositoryAutomobili();
        private IRepositoryGrupeZaPolaganje RepositoryGrupeZaPolaganje = new RepositoryGrupeZaPolaganje();


        public SluzbenikAutoSkole SluzbenikAutoSkole { get; set; }

        public bool Prijavljivanje(SluzbenikAutoSkole sluzbenik)
        {
            return repositorySluzbenikAutoSkole.Prijavljivanje(sluzbenik);
        }


        #region Polaznik
        public BindingList<Polaznik> VratiPolaznike()
        {
            return new BindingList<Polaznik>(repositoryPolaznik.VratiPolaznike());
        }

        public bool KreirajPolaznika(Polaznik polaznik)
        {
            return repositoryPolaznik.KreirajPolaznika(polaznik);
        }

        public Polaznik VratiPolaznika(Polaznik polaznik)
        {
            return repositoryPolaznik.VratiPolaznika(polaznik);
        }

        public bool ObrisiPolaznika(Polaznik polaznik)
        {
            return repositoryPolaznik.ObrisiPolaznika(polaznik);
        }

        public bool UpdatePolaznika(Polaznik polaznik)
        {
            return repositoryPolaznik.UpdatePolaznika(polaznik);
        }
        
        #endregion


        #region Instruktor
        public BindingList<Instruktor> VratiInstruktore(Kategorija? kategorija)
        {
            return new BindingList<Instruktor>(repositoryInstruktor.VratiInstruktore(kategorija));
        }

        public bool ObrisiInstruktora(Instruktor instruktor)
        {
            return repositoryInstruktor.ObrisiInstruktora(instruktor);
        }

        public bool UpdateInstruktora(Instruktor instruktor)
        {
            return repositoryInstruktor.UpdateInstruktora(instruktor);
        }
        
        #endregion


        #region Voznje
        public bool KreirajVoznju(Voznja voznja)
        {
            return repositoryVoznje.KreirajVoznju(voznja);
        }

        public BindingList<Voznja> VratiVoznje(Kategorija? kategorija)
        {
            return new BindingList<Voznja>(repositoryVoznje.VratiVoznje(kategorija));
        }
        
        #endregion


        #region Automobili
        public BindingList<Automobil> VratiAutomobile(Kategorija? kategorija)
        {
            return new BindingList<Automobil>(repositoryAutomobili.VratiAutomobile(kategorija));
        }

        #endregion


        #region Grupa za polaganje

        public bool KreirajGrupuZaPolaganje(List<Polaznik> polaznici, GrupaZaPolaganje grupaZaPolaganje)
        {
            return RepositoryGrupeZaPolaganje.KreirajGrupuZaPolaganje(polaznici);
        }

        public BindingList<GrupaZaPolaganje> VratiGrupeZaPolaganje()
        {
            return new BindingList<GrupaZaPolaganje>(RepositoryGrupeZaPolaganje.VratiGrupeZaPolaganje());
        }

        #endregion
    }
}
