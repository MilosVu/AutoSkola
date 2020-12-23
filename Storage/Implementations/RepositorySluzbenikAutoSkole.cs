using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementations
{
    public class RepositorySluzbenikAutoSkole : IRepositorySluzbenikAutoSkole
    {

        private List<SluzbenikAutoSkole> sluzbeniciAutoSkole;

        public RepositorySluzbenikAutoSkole()
        {
            this.sluzbeniciAutoSkole = new List<SluzbenikAutoSkole>()
            {
                new SluzbenikAutoSkole()
                {
                    Ime = "Milos",
                    Prezime = "Vujic",
                    Email = "milos.vujic@gmail.com",
                    KorisnickoIme = "Milos123",
                    Lozinka = "milos123"
                },
                new SluzbenikAutoSkole()
                {
                    Ime = "Petar",
                    Prezime = "Petrovic",
                    Email = "petar.petrovic@gmail.com",
                    KorisnickoIme = "Petar123",
                    Lozinka = "petar123"
                },
                new SluzbenikAutoSkole()
                {
                    Ime = "Admin",
                    Prezime = "Nalog",
                    Email = "admin.admin@gmail.com",
                    KorisnickoIme = "admin",
                    Lozinka = "admin"
                }
            };
        }

        public bool Prijavljivanje(SluzbenikAutoSkole sluzbenik)
        {
            return sluzbeniciAutoSkole.Any(s => s.KorisnickoIme == sluzbenik.KorisnickoIme
                                && s.Lozinka == sluzbenik.Lozinka);
        }
    }
}
