using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Instruktor
    {

        public int IdInstruktora { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public Kategorija Kategorija { get; set; }

    }
}
