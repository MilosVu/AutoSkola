using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Communication
{
    public class Communication
    {

        private static Communication instance;

        private Socket socket;
        private CommunicationClient klijent;

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        
        public void Connect()
        {
            if (socket != null && !socket.Connected)
            {
                socket.Connect("127.0.0.1", 9000);
                klijent = new CommunicationClient(socket);
            }
        }

        internal SluzbenikAutoSkole Prijavljivanje(TextBox txtLozinka, TextBox txtKorisnickoIme)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacije.Prijavljivanje,
                Objekat = new SluzbenikAutoSkole() { KorisnickoIme = txtKorisnickoIme.Text, Lozinka = txtLozinka.Text}
            };
            klijent.PosaljiZahtev(zahtev);
            return (SluzbenikAutoSkole)klijent.PrimiOdgovor();
        }

        internal BindingList<Object> VratiListu()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacije.VratiListu
            };
            klijent.PosaljiZahtev(zahtev);
            return (BindingList<Object>)klijent.PrimiOdgovor();
        }

        internal void Kreiraj(Object obj)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacije.Kreiraj
            };
            klijent.PosaljiZahtev(zahtev);
        }

        internal void Obrisi(Object obj)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacije.Obrisi
            };
            klijent.PosaljiZahtev(zahtev);
        }

        internal void Update(Object obj)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacije.Update
            };
            klijent.PosaljiZahtev(zahtev);
        }

        /*

        #region Instruktor

        public BindingList<Instruktor> VratiInstruktore(Kategorija? kategorija)
        {
            throw new NotImplementedException();
        }

        public bool ObrisiInstruktora(Instruktor instruktor)
        {
            throw new NotImplementedException();
        }

        public bool UpdateInstruktora(Instruktor instruktor)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Voznje

        public bool KreirajVoznju(Voznja voznja)
        {
            throw new NotImplementedException();
        }

        public BindingList<Voznja> VratiVoznje()
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Automobili

        public BindingList<Automobil> VratiAutomobile(Kategorija? kategorija)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Grupa za polaganje

        public bool KreirajGrupuZaPolaganje(List<Polaznik> polaznici, GrupaZaPolaganje grupaZaPolaganje)
        {
            throw new NotImplementedException();
        }

        public BindingList<GrupaZaPolaganje> VratiGrupeZaPolaganje()
        {
            throw new NotImplementedException();
        }

        public BindingList<Polaznik> VratiPolaznikaIGrupeZaPolaganje(int idGrupeZaPolaganje)
        {
            throw new NotImplementedException();
        }

        #endregion
        */
    }
}
