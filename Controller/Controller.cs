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
        public BindingList<Instruktor> VratiInstruktore()
        {
            return new BindingList<Instruktor>(repositoryInstruktor.VratiInstruktore());
        }

        public Instruktor VratiInstruktora(Instruktor instruktor)
        {
            return repositoryInstruktor.VratiInstruktora(instruktor);
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

    }
}
