using Common;
using ControllerClass;
using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Domain;

namespace Server
{
    internal class ClientHandler
    {
        private Socket klijent;

        public ClientHandler(Socket klijent)
        {
            this.klijent = klijent;
        }
        
        public void Zapocni()
        {
            try
            {
                NetworkStream stream = new NetworkStream(klijent);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor odgovor;
                    try
                    {
                        odgovor = ObradiZahtev(zahtev);
                    }
                    catch (Exception ex)
                    {
                        odgovor = new Odgovor();
                        odgovor.Uspesno = false;
                        odgovor.Greska = ex.Message;
                    }
                    formatter.Serialize(stream, odgovor);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
            }
        }

        private Odgovor ObradiZahtev(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Uspesno = true;
            
            switch (zahtev.Operacija)
            {
                case Operacije.Prijavljivanje:
                    odgovor.Rezultat = Controller.Instance.Prijavljivanje((SluzbenikAutoSkole)zahtev.Objekat);
                    break;
                default:
                    Console.WriteLine("Greska");
                    break;
            }
            return odgovor;
        }
        
    }
}