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
    public partial class FormaPrijavljivanje : Form
    {

        private Controller controller;

        public FormaPrijavljivanje()
        {
            InitializeComponent();
            FormeHelper.PostaviPozadinuTransparentnu(new Label[]{
                lblFormaZaPrijavljivanje,lblKorisnickoIme,lblLozinka
            });
            txtKorisnickoIme.Text = "admin";
            txtLozinka.Text = "admin";
            controller = Controller.Instance;
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if(!FormeHelper.TextFieldValidator(new TextBox[] {txtKorisnickoIme, txtLozinka}))
            {
                MessageBox.Show("Sva polja su obavezna");
                return;
            }

            SluzbenikAutoSkole sluzbenikAutoSkole = new SluzbenikAutoSkole()
            {
                KorisnickoIme = txtKorisnickoIme.Text,
                Lozinka = txtLozinka.Text
            };

            if (controller.Prijavljivanje(sluzbenikAutoSkole))
            {
                controller.SluzbenikAutoSkole = sluzbenikAutoSkole;
                MessageBox.Show("Dobro dosli.");
                FormaGlavna formaGlavna = new FormaGlavna();
                this.Visible = false;
                formaGlavna.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Pogresno korisnicko ime ili lozinka.");
            }

        }

        private void cbPrikazLoznike_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrikazLoznike.Checked)
                txtLozinka.PasswordChar = '\0';
            else
                txtLozinka.PasswordChar = '*';
        }
    }
}
