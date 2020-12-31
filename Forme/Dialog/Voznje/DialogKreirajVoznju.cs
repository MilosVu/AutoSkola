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
    public partial class DialogKreirajVoznju : Form
    {

        Controller controller;

        public DialogKreirajVoznju()
        {
            InitializeComponent();
            this.controller = Controller.Instance;
            FormeHelper.PostaviPozadinuTransparentnu(new Label[] {
                lblPolaznik, lblInstruktora, lblDatum, lblBrojCasa, lblRealizovan, lblAutomobil
            });
        }

        private void DialogKreirajVoznju_Load(object sender, EventArgs e)
        {
            cbPolaznik.DataSource = controller.VratiPolaznike();
            cbRealizovan.DataSource = new bool[] { true, false };
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojCasa.Text))
            {
                MessageBox.Show("Popunite polje za broj casa.");
                return;
            }

            int brojCasa;
            if(!int.TryParse(txtBrojCasa.Text, out brojCasa))
            {
                MessageBox.Show("Polje za broj casa mora biti broj.");
                return;
            }
            if(brojCasa <= 0 || brojCasa > 40)
            {
                MessageBox.Show("Broj casa mora biti izmedju 1 i 40");
                return;
            }
            if (cbAutomobil.SelectedItem == null || cbInstruktor.SelectedItem == null || 
                cbPolaznik.SelectedItem == null || cbRealizovan.SelectedItem == null)
            {
                MessageBox.Show("Izaberite sva polja.");
                return;
            }

            Voznja voznja = new Voznja()
            {
                Polaznik = cbPolaznik.SelectedItem as Polaznik,
                Instruktor = cbInstruktor.SelectedItem as Instruktor,
                BrojCasa = brojCasa,
                Datum = dateTimePicker.Value,
                Realizovan = (bool) cbRealizovan.SelectedItem,
                Automobil = cbAutomobil.SelectedItem as Automobil
            };

            if (controller.KreirajVoznju(voznja))
            {
                MessageBox.Show("Sistem je zapamtio novu voznju!");
                UCVoznja.voznje.Add(voznja);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti novog polaznika.");
            }
        }

        private void cbPolaznik_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategorija kategorija = ((Polaznik)cbPolaznik.SelectedItem).Kategorija;
            cbInstruktor.DataSource = controller.VratiInstruktore(kategorija);
            cbAutomobil.DataSource = controller.VratiAutomobile(kategorija);
        }
    }
}
