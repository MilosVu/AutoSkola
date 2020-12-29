using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IRepositoryPolaznik
    {

        List<Polaznik> VratiPolaznike();

        Polaznik VratiPolaznika(Polaznik polaznik);

        bool KreirajPolaznika(Polaznik polaznik);

        bool IzmeniPolaznika(Polaznik polaznik);

        bool ObrisiPolaznika(Polaznik polaznik);

        bool UpdatePolaznika(Polaznik polaznik);
    }
}
