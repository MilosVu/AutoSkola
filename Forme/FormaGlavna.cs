using ControllerClass;
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

namespace Forme
{
    public partial class FormaGlavna : Form
    {

        private Controller controller;

        public FormaGlavna()
        {
            InitializeComponent();
            this.controller = Controller.Instance;
        }

        private void FormaGlavna_Load(object sender, EventArgs e)
        {
            lblUlogovanKorisnik.Text += " " + controller.SluzbenikAutoSkole.KorisnickoIme;
        }

        private void prikazPolaznikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPanel(new UCPolaznici());
        }

        private void prikazInstruktoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPanel(new UCInstruktor());
        }

        private void prikazVoznjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPanel(new UCVoznja());
        }

        private void SetPanel(UserControl userControl)
        {
            panelGlavni.Controls.Clear();
            userControl.Parent = panelGlavni;
            userControl.Dock = DockStyle.Fill;
        }
    }
}
