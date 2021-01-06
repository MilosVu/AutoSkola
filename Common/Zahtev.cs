using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Zahtev
    {

        public Operacije Operacija { get; set; }

        public object Objekat { get; set; }

    }
}
