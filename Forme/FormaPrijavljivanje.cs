using Domain;
using Forme.Controller;
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
    public partial class FormaPrijavljivanje : Form
    {

        private ControllerPrijavljivanje controllerPrijavljivanje;

        public FormaPrijavljivanje(ControllerPrijavljivanje controllerPrijavljivanje)
        {
            InitializeComponent();
            txtKorisnickoIme.Text = "admin";
            txtLozinka.Text = "admin";
            this.controllerPrijavljivanje = controllerPrijavljivanje;

        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            controllerPrijavljivanje.Prijavljivanje(txtKorisnickoIme, txtLozinka, this);
        }

        private void cbPrikazLoznike_CheckedChanged(object sender, EventArgs e)
        {
            controllerPrijavljivanje.PrikazLozinke(cbPrikazLoznike, txtLozinka);
        }

        private void FormaPrijavljivanje_Load(object sender, EventArgs e)
        {
            controllerPrijavljivanje.KonektujSe();
        }
    }
}
