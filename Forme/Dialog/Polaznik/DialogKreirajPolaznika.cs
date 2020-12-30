using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormeHelpers;
using ControllerClass;
using Domain;

namespace Forme
{
    public partial class DialogKreirajPolaznika : Form
    {

        Controller controller;
        
        public DialogKreirajPolaznika()
        {
            InitializeComponent();
            this.controller = Controller.Instance;
            FormeHelper.PostaviPozadinuTransparentnu(new Label[] {
                lblIme, lblPrezime, lblDatumRodjenja, lblKategorija 
            });
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(!FormeHelper.TextFieldValidator(new TextBox[] { txtIme, txtPrezime }))
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }
            if(cbKategorija.SelectedItem == null)
            {
                MessageBox.Show("Izaberite kategoriju");
                return;
            }

            Polaznik polaznik = new Polaznik()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumRodjenja = dateTimePicker.Value,
                Kategorija = (Kategorija) cbKategorija.SelectedItem
            };

            if (controller.KreirajPolaznika(polaznik))
            {
                MessageBox.Show("Sistem je zapamtio novog polaznik!");
                Polaznik novPol = controller.VratiPolaznika(polaznik);
                MessageBox.Show(novPol.ToString());
                UCPolaznici.polaznici.Add(novPol);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da zapamti novog polaznika.");
            }
        }
        
        private void DialogKreirajPolaznika_Load(object sender, EventArgs e)
        {
            FormeHelper.PopuniComboBoxKategorije(cbKategorija);
        }
    }
}
