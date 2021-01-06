using Domain;
using Forme.Exceptions;
using FormeHelpers;
using System;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class ControllerPrijavljivanje
    {

        internal void KonektujSe()
        {
            try
            {
                Communication.Communication.Instance.Connect();
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Greska pri povezivanju sa serverom!");
                Environment.Exit(0);
            }
        }

        internal void Prijavljivanje(TextBox txtKorisnickoIme, TextBox txtLozinka, FormaPrijavljivanje formaPrijavljivanje)
        {
            if(!FormeHelper.TextFieldValidator(new TextBox[] { txtKorisnickoIme, txtLozinka }))
            {
                MessageBox.Show("Sva polja su obavezna.");
                return;
            }

            try
            {
                MainCoordinator.Instance.SluzbenikAutoSkole = Communication.Communication.Instance.Prijavljivanje(txtKorisnickoIme, txtLozinka);
                MainCoordinator.Instance.OtvoriGlavnuFormu();
                formaPrijavljivanje.Dispose();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void PrikazLozinke(CheckBox cbPrikazLoznike, TextBox txtLozinka)
        {
            if (cbPrikazLoznike.Checked)
                txtLozinka.PasswordChar = '\0';
            else
                txtLozinka.PasswordChar = '*';
        }
    }
}
