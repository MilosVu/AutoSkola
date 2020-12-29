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

        bool ObrisiInstruktora(Instruktor instruktor);

        bool UpdateInstruktora(Instruktor instruktor);
    }
}
