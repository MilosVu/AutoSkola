using ControllerClass;
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

namespace Forme
{
    public partial class UCPolaznici : UserControl
    {

        public static BindingList<Polaznik> polaznici;
        private Controller controller = Controller.Instance;
        private bool zavrseno = false;

        public UCPolaznici()
        {
            InitializeComponent();
            lblPolaznici.BackColor = System.Drawing.Color.Transparent;
            polaznici = controller.VratiPolaznike();
            cbKategorijeZaPretragu.Items.Add("Sve kategorije");
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.A);
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.B);
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.C);
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.D);
        }

        private void UCPolaznici_Load(object sender, EventArgs e)
        {
            FormeHelper.PopuniComboBoxKategorijeDataGrid(cbKategorija);
            cbKategorijeZaPretragu.SelectedIndex = 0;
            dataGridPolaznici.DataSource = polaznici;
        }

        private void btnKreirajPolaznika_Click(object sender, EventArgs e)
        {
            DialogKreirajPolaznika dialogKreirajPolaznika = new DialogKreirajPolaznika();
            dialogKreirajPolaznika.ShowDialog();
        }

        private void btnIzbrisiPolaznika_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Da li ste sigurni da želite da izbrišete polaznika",
                "Brisanje", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) 
                return;

            Polaznik polaznik = dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik;
            if (controller.ObrisiPolaznika(polaznik))
            {
                MessageBox.Show("Sistem je obrisao polaznika.");
                polaznici.Remove(polaznik);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da obrise polaznika.");
            }
        }

        private void dataGridPolaznici_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!zavrseno)
                return;

            var result = MessageBox.Show("Da li ste sigurni da želite da promenite podatke polaznika",
                "Promena podataka", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                dataGridPolaznici.CancelEdit();
                dataGridPolaznici.RefreshEdit();
                return;
            }

            if (dataGridPolaznici.CurrentRow == null)
                return;
            Polaznik polaznik = dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik;
            controller.UpdatePolaznika(polaznik);
        }

        private void dataGridPolaznici_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridPolaznici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogPrikazPolaznika dialogPrikazPolaznika = 
                new DialogPrikazPolaznika(dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik);
            dialogPrikazPolaznika.ShowDialog();
        }

        private void dataGridPolaznici_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            zavrseno = true;
        }

        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategorijeZaPretragu.SelectedIndex == 0)
            {
                dataGridPolaznici.DataSource = controller.VratiPolaznike();
            }
            else
            {
                dataGridPolaznici.DataSource = new List<Polaznik>(polaznici).FindAll(p => p.Kategorija == (Kategorija) cbKategorijeZaPretragu.SelectedItem);
            }
            dataGridPolaznici.Refresh();
            
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
