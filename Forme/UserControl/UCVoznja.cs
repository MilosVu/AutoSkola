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
    public partial class UCVoznja : UserControl
    {

        public static BindingList<Voznja> voznje;
        private Controller controller = Controller.Instance;

        public UCVoznja()
        {
            InitializeComponent();
            voznje = controller.VratiVoznje(null);
            FormeHelper.PostaviPozadinuTransparentnu(new Label[] { lblPretraga, lblVoznje });
        }

        private void UCVoznja_Load(object sender, EventArgs e)
        { 
            dataGridVoznje.DataSource = voznje;
            cbKategorija.Items.Add("Sve kategorije");
            cbKategorija.Items.Add(Domain.Kategorija.A);
            cbKategorija.Items.Add(Domain.Kategorija.B);
            cbKategorija.Items.Add(Domain.Kategorija.C);
            cbKategorija.Items.Add(Domain.Kategorija.D);
            cbKategorija.SelectedIndex = 0;
        }

        private void btnKreirajVoznju_Click(object sender, EventArgs e)
        {
            DialogKreirajVoznju kreirajVoznju = new DialogKreirajVoznju();
            kreirajVoznju.ShowDialog();
        }

        private void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategorija.SelectedIndex == 0)
            {
                dataGridVoznje.DataSource = controller.VratiVoznje(null);
            }
            else
            {
                dataGridVoznje.DataSource = controller.VratiVoznje((Kategorija) cbKategorija.SelectedItem);
            }
                dataGridVoznje.Refresh();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            dataGridVoznje.DataSource = Filtriraj(txtPretraga.Text.ToLower());
            dataGridVoznje.Refresh();
        }

        private BindingList<Voznja> Filtriraj(string tekstPretrage)
        {
            BindingList<Voznja> filtriraneVoznje = new BindingList<Voznja>();
            foreach(Voznja v in voznje)
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

    }
}
