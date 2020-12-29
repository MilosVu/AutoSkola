using ControllerClass;
using Domain;
using FormeHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class DialogPrikazInstruktora : Form
    {

        private Instruktor instruktor;
        private Controller controller;

        public DialogPrikazInstruktora(Instruktor instruktor)
        {
            InitializeComponent();
            this.instruktor = instruktor;
            this.controller = Controller.Instance;
            FormeHelper.PostaviPozadinuTransparentnu(new Label[]{
            lblIme, lblKategorija, lblInstruktor, lblPrezime
            });
            FormeHelper.PopuniComboBoxKategorije(cbKategorija);
        }

        private void DialogPrikazInstruktora_Load(object sender, EventArgs e)
        {
            txtIme.Text = instruktor.Ime;
            txtPrezime.Text = instruktor.Prezime;
            cbKategorija.SelectedItem = instruktor.Kategorija;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            Instruktor novInstruktor= new Instruktor()
            {
                IdInstruktora = this.instruktor.IdInstruktora,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Kategorija = (Kategorija)cbKategorija.SelectedItem
            };

            if (controller.UpdateInstruktora(novInstruktor))
            {
                ZameniInstruktora(novInstruktor);
                MessageBox.Show("Sacuvane izmene polaznika.");
            }
            else
            {
                MessageBox.Show("Greska prilikom cuvanja izmena.");
            }
        }

        private void ZameniInstruktora(Instruktor novInstruktor)
        {
            Instruktor instruktor = UCInstruktor.instruktori.First(i => i.IdInstruktora == novInstruktor.IdInstruktora);
            instruktor.Ime = novInstruktor.Ime;
            instruktor.Prezime = novInstruktor.Prezime;
            instruktor.Kategorija = novInstruktor.Kategorija;
        }

    }
}
