using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GrupaZaPolaganje
    {

        public int IdGrupeZaPolaganje { get; set; }

        public DateTime Datum { get; set; }

        public Kategorija Kategorija { get; set; }

        public VrstaIspita VrstaIspita{ get; set; }

        public List<Polaznik> Polaznici { get; set; }

    }
}
