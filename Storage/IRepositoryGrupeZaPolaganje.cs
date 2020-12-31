using Domain;
using System;
using System.Collections.Generic;


namespace Storage
{
    public interface IRepositoryGrupeZaPolaganje
    {
        bool KreirajGrupuZaPolaganje(List<Polaznik> polaznici);

        List<GrupaZaPolaganje> VratiGrupeZaPolaganje();

    }
}
