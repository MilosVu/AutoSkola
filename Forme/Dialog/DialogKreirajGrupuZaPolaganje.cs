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
    public partial class DialogKreirajGrupuZaPolaganje : Form
    {
        private List<Polaznik> polaznici;
        private Controller controller;

        public DialogKreirajGrupuZaPolaganje(List<Polaznik> polaznici)
        {
            InitializeComponent();
            this.polaznici = polaznici;
            
        }

        private void DialogKreirajGrupuZaPolaganje_Load(object sender, EventArgs e)
        {
            dataGridPolaznici.DataSource = polaznici;
            this.controller = Controller.Instance;
            cbVrstaIspita.DataSource = new VrstaIspita[] {VrstaIspita.Prakticni, VrstaIspita.Teorijski };
        }

        private void btnDodajGrupuZaPolaganje_Click(object sender, EventArgs e)
        {
            GrupaZaPolaganje grupaZaPolaganje = new GrupaZaPolaganje()
            {
                Datum = dateTimePicker.Value,
                Kategorija = polaznici[0].Kategorija,
                VrstaIspita = (VrstaIspita) cbVrstaIspita.SelectedItem,
                Sala = txtSala.Text
            };
            if(controller.KreirajGrupuZaPolaganje(polaznici, grupaZaPolaganje))
            {
                MessageBox.Show("Kreirana je nova grupa za polaganje.");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da kreira novu grupu za polaganje.");
            }
        }
    }
}
