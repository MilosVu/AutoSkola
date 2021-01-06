using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Controller
{
    public class ControllerGlavni
    {

        internal void OtvoriUCPolaznici (FormaGlavna forma)
        {
            forma.SetPanel(new UCPolaznici(new Controller.ControllerPolaznik()));
        }

        internal void OtvoriUCVoznja(FormaGlavna forma)
        {
            forma.SetPanel(new UCVoznja(new Controller.ControllerVoznja()));
        }

        internal void OtvoriUCInstruktor(FormaGlavna forma)
        {
            forma.SetPanel(new UCVoznja(new Controller.ControllerVoznja()));
        }

        internal void OtvoriUCGrupaZaPolaganje(FormaGlavna forma)
        {
            forma.SetPanel(new UCGrupaZaPolaganje(new Controller.ControllerGrupaZaPolaganje()));
        }

    }
}
