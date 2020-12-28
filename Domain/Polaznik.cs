using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Polaznik
    {

        public int IdPolaznika{ get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public DateTime DatumRodjenja { get; set; }

        public Kategorija Kategorija { get; set; }

        public override string ToString()
        {
            return $"{IdPolaznika} {Ime} {Prezime}";
        }
    }
}
