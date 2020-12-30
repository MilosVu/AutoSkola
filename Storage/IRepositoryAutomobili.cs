using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IRepositoryAutomobili
    {

        List<Automobil> VratiAutomobile(Kategorija? kategorija);

    }
}
