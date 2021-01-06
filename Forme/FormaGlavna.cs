using System;
using System.Windows.Forms;
using Forme.Controller;

namespace Forme
{
    public partial class FormaGlavna : Form
    {

        private readonly ControllerGlavni controllerGlavni;

        public FormaGlavna(ControllerGlavni controllerGlavni)
        {
            InitializeComponent();
            this.controllerGlavni = controllerGlavni;
        }

        private void FormaGlavna_Load(object sender, EventArgs e)
        {
            lblUlogovanKorisnik.Text += " UNESI OVDE IME";
        }

        public void SetPanel(UserControl userControl)
        {
            panelGlavni.Controls.Clear();
            userControl.Parent = panelGlavni;
            userControl.Dock = DockStyle.Fill;
        }

        private void grupeZaPolaganjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controllerGlavni.OtvoriUCGrupaZaPolaganje(this);
        }

        private void polazniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controllerGlavni.OtvoriUCPolaznici(this);
        }

        private void instruktoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controllerGlavni.OtvoriUCInstruktor(this);
        }

        private void voznjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controllerGlavni.OtvoriUCVoznja(this);
        }
    }
}
