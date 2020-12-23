using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IRepositoryInstruktor
    {

        List<Instruktor> vratiInstruktore();

        Instruktor vratiInstruktora(Instruktor instruktor);

        bool izmeniInstruktora(Instruktor instruktor);

        void brisiInstruktora(Instruktor instruktor);

    }
}
