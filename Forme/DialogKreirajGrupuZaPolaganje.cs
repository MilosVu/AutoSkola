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
            controller.KreirajGrupuZaPolaganje(polaznici);
        }
    }
}
