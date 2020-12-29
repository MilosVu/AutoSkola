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
    public partial class UCInstruktor : UserControl
    {

        public static BindingList<Instruktor> instruktori;
        private Controller controller = Controller.Instance;

        public UCInstruktor()
        {
            InitializeComponent();
            lblInstruktori.BackColor = System.Drawing.Color.Transparent;
            instruktori = controller.VratiInstruktore();
        }

        private void UCInstruktor_Load(object sender, EventArgs e)
        {
            FormeHelper.PopuniComboBoxKategorijeDataGrid(cbKategorija);
            dataGridInstruktori.DataSource = instruktori;
        }

        private void btnIzbrisiInstruktora_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete polaznika",
                "Brisanje", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            Instruktor instruktor = dataGridInstruktori.CurrentRow.DataBoundItem as Instruktor ;
            if (controller.ObrisiInstruktora(instruktor))
            {
                MessageBox.Show("Sistem je obrisao polaznika.");
                instruktori.Remove(instruktor);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da obrise polaznika.");
            }
        }

        private void dataGridInstruktori_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridInstruktori.CurrentRow == null)
                return;
            Instruktor instruktor = dataGridInstruktori.CurrentRow.DataBoundItem as Instruktor;
            controller.UpdateInstruktora(instruktor);
        }

        private void dataGridInstruktori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogPrikazInstruktora dialogPrikazInstruktora =
                new DialogPrikazInstruktora(dataGridInstruktori.CurrentRow.DataBoundItem as Instruktor);
            dialogPrikazInstruktora.ShowDialog();
        }
    }
}
