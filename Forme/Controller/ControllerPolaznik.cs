using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class ControllerPolaznik
    {

        public static BindingList<Polaznik> polaznici;

        public BindingList<Polaznik> VratiPolaznike()
        {
            throw new NotImplementedException();
        }

        public bool KreirajPolaznika(Polaznik polaznik)
        {
            throw new NotImplementedException();
        }

        public Polaznik VratiPolaznika(Polaznik polaznik)
        {
            throw new NotImplementedException();
        }

        public void ObrisiPolaznika(Polaznik polaznik)
        {

            var result = MessageBox.Show("Da li ste sigurni da želite da izbrišete polaznika",
                "Brisanje", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            try
            {
                Communication.Communication.Instance.Obrisi(polaznik);
                MessageBox.Show("Sistem je obrisao polaznika.");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da obrise polaznika.");
            }

        }

        internal void NapuniCbKategorije(ComboBox cbKategorijeZaPretragu)
        {
            cbKategorijeZaPretragu.Items.Add("Sve kategorije");
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.A);
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.B);
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.C);
            cbKategorijeZaPretragu.Items.Add(Domain.Kategorija.D);
            cbKategorijeZaPretragu.SelectedIndex = 0;
        }

        internal void OtvoriDialogKreirajPolaznika()
        {
            DialogKreirajPolaznika dialogKreirajPolaznika = new DialogKreirajPolaznika();
            dialogKreirajPolaznika.ShowDialog();
        }

        internal void NapuniDataGridPolaznici(DataGridView dataGridPolaznici)
        {
            dataGridPolaznici.DataSource = polaznici;
        }

        public void UpdatePolaznika(Polaznik polaznik, DataGridView dataGridPolaznici)
        {
            if (dataGridPolaznici.CurrentRow == null)
            {
                MessageBox.Show("Niste izabrali polaznika");
                return;
            }

            var result = MessageBox.Show("Da li ste sigurni da želite da promenite podatke polaznika",
                "Promena podataka", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                dataGridPolaznici.CancelEdit();
                dataGridPolaznici.RefreshEdit();
                return;
            }

            try
            {
                Communication.Communication.Instance.Update(polaznik);
                MessageBox.Show("Podaci o polazniku su izmenjeni.");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da izmeni podatke o polazniku.");
            }

        }

        internal void PromenaKategorije(ComboBox cbKategorijeZaPretragu, DataGridView dataGridPolaznici)
        {
            if (cbKategorijeZaPretragu.SelectedIndex == 0)
            {
                dataGridPolaznici.DataSource = polaznici;
            }
            else
            {
                dataGridPolaznici.DataSource = new List<Polaznik>(polaznici).FindAll(p => p.Kategorija == (Kategorija)cbKategorijeZaPretragu.SelectedItem);
            }
            dataGridPolaznici.Refresh();

        }

        internal void OtvoriDialogPrikazPolaznika(Polaznik polaznik)
        {
            DialogPrikazPolaznika dialogPrikazPolaznika =
                new DialogPrikazPolaznika(polaznik);
            dialogPrikazPolaznika.ShowDialog();
        }
    }
}
