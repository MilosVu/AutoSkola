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

        List<Instruktor> VratiInstruktore();

        Instruktor VratiInstruktora(Instruktor instruktor);

        bool IzmeniInstruktora(Instruktor instruktor);

        void BrisiInstruktora(Instruktor instruktor);

    }
}
