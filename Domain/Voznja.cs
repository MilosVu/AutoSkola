using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Voznja
    {

        public Kategorija Kategorija { get; set; }

        public Polaznik Polaznik { get; set; }

        public Instruktor Instruktor { get; set; }

        public DateTime Datum { get; set; }

        public int BrojCasa { get; set; }

        public bool Realizovan { get; set; }

        public Automobil Automobil { get; set; }

    }
}
