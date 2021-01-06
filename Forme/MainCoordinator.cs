using Domain;
using Forme.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme
{
    public class MainCoordinator
    {

        private ControllerGlavni mainController = new ControllerGlavni();
        private ControllerPrijavljivanje controllerPrijavljivanje= new ControllerPrijavljivanje();
        private FormaGlavna formaGlavna;
        private FormaPrijavljivanje formaPrijavljivanje;

        public SluzbenikAutoSkole SluzbenikAutoSkole { get; set; }

        private static MainCoordinator instance;
        private MainCoordinator() { }

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        public void OtvoriFormuZaPrijavljivanje()
        {
            formaPrijavljivanje = new FormaPrijavljivanje(controllerPrijavljivanje);
            formaPrijavljivanje.Show();
        }

        public void OtvoriGlavnuFormu()
        {
            formaGlavna = new FormaGlavna(mainController);
            formaGlavna.Show();
        }

    }
}
