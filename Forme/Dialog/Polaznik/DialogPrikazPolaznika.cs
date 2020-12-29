using Domain;
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

namespace Forme
{
    public partial class DialogPrikazPolaznika : Form
    {

        private Polaznik polaznik;
        private Controller controller;

        public DialogPrikazPolaznika(Polaznik polaznik)
        {
            InitializeComponent();
            this.polaznik = polaznik;
            this.controller = Controller.Instance;
            FormeHelper.PostaviPozadinuTransparentnu(new Label[]{
            lblDatumRodjenja, lblIme, lblKategorija, lblPolaznik, lblPrezime
            });
            FormeHelper.PopuniComboBoxKategorije(cbKategorija);
        }

        private void DialogPrikazPolaznika_Load(object sender, EventArgs e)
        {
            txtIme.Text = polaznik.Ime;
            txtPrezime.Text = polaznik.Prezime;
            dateTimePicker.Value = polaznik.DatumRodjenja;
            cbKategorija.SelectedItem = polaznik.Kategorija;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            Polaznik novPolaznik = new Polaznik()
            {
                IdPolaznika = this.polaznik.IdPolaznika,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumRodjenja = dateTimePicker.Value,
                Kategorija = (Kategorija)cbKategorija.SelectedItem
            };

            if (controller.UpdatePolaznika(novPolaznik))
            {
                ZameniPolaznika(novPolaznik);
                MessageBox.Show("Sacuvane izmene polaznika.");
            }
            else
            {
                MessageBox.Show("Greska prilikom cuvanja izmena.");
            }
        }
    
        private void ZameniPolaznika(Polaznik novPolaznik)
        {
            Polaznik polaznik = UCPolaznici.polaznici.First(p => p.IdPolaznika == novPolaznik.IdPolaznika);
            polaznik.Ime = novPolaznik.Ime;
            polaznik.Prezime = novPolaznik.Prezime;
            polaznik.DatumRodjenja = novPolaznik.DatumRodjenja;
            polaznik.Kategorija = novPolaznik.Kategorija;
        }
    }
}
