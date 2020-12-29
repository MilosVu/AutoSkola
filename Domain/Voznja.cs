using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Voznja
    {

        public int IdPolaznika { get; set; }

        public string ImeIPrezimePolaznika { get; set; }

        public int IdInstruktora { get; set; }

        public string ImeIPrezimeInstruktora { get; set; }

        public DateTime Datum { get; set; }

        public int BrojCasa { get; set; }

        public bool Realizovan { get; set; }

        public int IdAutomobila { get; set; }

        public string Automobil { get; set; }

    }
}
