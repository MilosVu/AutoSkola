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
        private IRepositoryInstruktor repositoryInstruktor;
        
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

        public bool Update(Polaznik polaznik)
        {
            return repositoryPolaznik.Update(polaznik);
        }
        #endregion

        #region Instruktor

        #endregion

    }
}
