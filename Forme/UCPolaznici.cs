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

        public UCPolaznici()
        {
            InitializeComponent();
            lblPolaznici.BackColor = System.Drawing.Color.Transparent;
            polaznici = controller.VratiPolaznike();
        }

        private void UCPolaznici_Load(object sender, EventArgs e)
        {
            //cbKategorija.ValueMember = "Kategorija";
            //cbKategorija.DisplayMember = "A";
            FormeHelper.PopuniComboBoxKategorijeDataGrid(cbKategorija);
            dataGridPolaznici.DataSource = polaznici;

        }

        private void btnKreirajPolaznika_Click(object sender, EventArgs e)
        {
            DialogKreirajPolaznika dialogKreirajPolaznika = new DialogKreirajPolaznika();
            dialogKreirajPolaznika.ShowDialog();
        }

        private void btnIzbrisiPolaznika_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete polaznika",
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
            if (dataGridPolaznici.CurrentRow == null)
                return;
            Polaznik polaznik = dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik;
            controller.UpdatePolaznika(polaznik);
        }

        private void dataGridPolaznici_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridPolaznici_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void dataGridPolaznici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogPrikazPolaznika dialogPrikazPolaznika = 
                new DialogPrikazPolaznika(dataGridPolaznici.CurrentRow.DataBoundItem as Polaznik);
            dialogPrikazPolaznika.ShowDialog();
        }
    }
}
