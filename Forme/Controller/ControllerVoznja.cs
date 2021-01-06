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
    public class ControllerVoznja
    {

        internal static BindingList<Voznja> voznje;

        internal bool KreirajVoznju(Voznja voznja)
        {
            throw new NotImplementedException();
        }

        internal void UcitajVoznje()
        {
            voznje = new BindingList<Voznja>(new List<Voznja>(Communication.Communication.Instance.VratiListu().Cast<Voznja>()));
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

        internal void NapuniDataGridVoznje(DataGridView dataGridVoznje)
        {
            dataGridVoznje.DataSource = voznje;
        }

        internal void OtvoriDialogKreirajVoznju()
        {
            DialogKreirajVoznju kreirajVoznju = new DialogKreirajVoznju();
            kreirajVoznju.ShowDialog();
        }

        internal void PromenaKategorije(ComboBox cbKategorijeZaPretragu, DataGridView dataGridPolaznici)
        {
            if (cbKategorijeZaPretragu.SelectedIndex == 0)
            {
                dataGridPolaznici.DataSource = voznje;
            }
            else
            {
                dataGridPolaznici.DataSource = new List<Voznja>(voznje).FindAll(v => 
                v.Kategorija == (Kategorija)cbKategorijeZaPretragu.SelectedItem);
            }
            dataGridPolaznici.Refresh();
        }

        private BindingList<Voznja> Filtriraj(string tekstPretrage)
        {
            BindingList<Voznja> filtriraneVoznje = new BindingList<Voznja>();
            foreach (Voznja v in voznje)
            {
                string stringVoznje = $"{v.Polaznik.Ime} {v.Polaznik.Prezime} {v.Instruktor.Ime} " +
                    $"{v.Instruktor.Prezime} {v.Automobil.Marka} {v.Automobil.Model}";
                stringVoznje = stringVoznje.ToLower();
                if (stringVoznje.Contains(tekstPretrage))
                {
                    filtriraneVoznje.Add(v);
                }
            }
            return filtriraneVoznje;
        }

        internal void FiltrirajPretragu(DataGridView dataGridVoznje, TextBox txtPretraga)
        {
            dataGridVoznje.DataSource = Filtriraj(txtPretraga.Text.ToLower());
            dataGridVoznje.Refresh();
        }

    }
}
