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
using Forme.Controller;

namespace Forme
{
    public partial class UCPolaznici : UserControl
    {

        private ControllerPolaznik controllerPolaznik;
        private bool zavrseno = false;
        public UCPolaznici(ControllerPolaznik controllerPolaznik)
        {
            InitializeComponent();
            this.controllerPolaznik = controllerPolaznik;
            //lblPolaznici.BackColor = System.Drawing.Color.Transparent;
            //polaznici = controller.VratiPolaznike();
            this.controllerPolaznik.NapuniCbKategorije(cbKategorijeZaPretragu);

        }

        private void UCPolaznici_Load(object sender, EventArgs e)
        {
            FormeHelper.PopuniComboBoxKategorijeDataGrid(cbKategorija);
            controllerPolaznik.NapuniDataGridPolaznici(dataGridPolaznici);
        }

        private void btnKreirajPolaznika_Click(object sender, EventArgs e)
        {
            controllerPolaznik.OtvoriDialogKreirajPolaznika();
        }

        private void btnIzbrisiPolaznika_Click(object sender, EventArgs e)
        {
            if(dataGridPolaznici.CurrentRow == null)
            {
                MessageBox.Show("Niste izabrali red.");
                return;
            }
            controllerPolaznik.ObrisiPolaznika(dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik);
        }
        
        private void dataGridPolaznici_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!zavrseno)
                return;

            Polaznik polaznik = dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik;
            controllerPolaznik.UpdatePolaznika(polaznik, dataGridPolaznici);

        }

        private void dataGridPolaznici_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridPolaznici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            controllerPolaznik.OtvoriDialogPrikazPolaznika(dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik);
        }

        private void dataGridPolaznici_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            zavrseno = true;
        }

        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            controllerPolaznik.PromenaKategorije(cbKategorijeZaPretragu, dataGridPolaznici);
        }

        private void btnDodajGrupuZaPolaganje_Click(object sender, EventArgs e)
        {
            int counter = dataGridPolaznici.SelectedRows.Count;
            if (counter == 0)
            {
                MessageBox.Show("Nijedan polaznik nije selektovan.");
                return;
            }

            List<Polaznik> selektovaniPolaznici = new List<Polaznik>();
            for(int i = 0; i < counter; i++)
            {
                selektovaniPolaznici.Add((Polaznik)dataGridPolaznici.SelectedRows[i].DataBoundItem);
            }

            Kategorija kategorija = selektovaniPolaznici[0].Kategorija;
            if (!selektovaniPolaznici.All(p => p.Kategorija == kategorija))
            {
                MessageBox.Show("Svi selektovani polaznici moraju polagati za istu kategoriju.");
                return;
            }

            DialogKreirajGrupuZaPolaganje kreirajGrupuZaPolaganje = new DialogKreirajGrupuZaPolaganje(selektovaniPolaznici);
            kreirajGrupuZaPolaganje.ShowDialog();
        }
    }
}
