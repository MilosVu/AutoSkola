﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IRepositoryVoznje
    {

        List<Voznja> VratiVoznje(Kategorija? kategorija);

        bool KreirajVoznju(Voznja voznja);

    }
}
