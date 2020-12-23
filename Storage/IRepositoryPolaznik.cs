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

        List<Polaznik> vratiPolaznike(List<Polaznik> polaznici);

        Polaznik vratiPolaznika(Polaznik polaznik);

        bool kreirajPolaznika(Polaznik polaznik);

        bool izmeniPolaznika(Polaznik polaznik);

        void obrisiPolaznika(Polaznik polaznik);
    }
}
