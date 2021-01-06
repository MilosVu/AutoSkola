using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Common;
using Forme.Exceptions;

namespace Forme.Communication
{
    internal class CommunicationClient
    {

        private Primanje primanje;
        private Slanje slanje;

        public CommunicationClient(Socket socket)
        {
            primanje = new Primanje(socket);
            slanje = new Slanje(socket);
        }

        public void PosaljiZahtev(Zahtev zahtev)
        {
            slanje.Posalji(zahtev);
        }

        public object PrimiOdgovor()
        {
            Odgovor odgovor = (Odgovor) primanje.Primi();
            if (odgovor.Uspesno)
            {
                return odgovor.Rezultat;
            }
            else
            {
                throw new SystemOperationException(odgovor.Greska);
            }
        }

    }
}
