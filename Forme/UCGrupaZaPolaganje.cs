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

namespace Forme
{
    public partial class UCGrupaZaPolaganje : UserControl
    {
        private Controller controller = Controller.Instance;

        public UCGrupaZaPolaganje()
        {
            InitializeComponent();
        }

        private void UCGrupaZaPolaganje_Load(object sender, EventArgs e)
        {
            dataGridGrupeZaPolaganje.DataSource = controller.VratiGrupeZaPolaganje();
        }

        private void dataGridGrupeZaPolaganje_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GrupaZaPolaganje grupaZaPolaganje = (dataGridGrupeZaPolaganje.CurrentRow.DataBoundItem as GrupaZaPolaganje);
            lblGrupeZaPolaganje.Text = $"Grupa za polaganje: {grupaZaPolaganje.IdGrupeZaPolaganje}";
            dataGridGrupeZaPolaganje.DataSource = controller.VratiPolaznikaIGrupeZaPolaganje(grupaZaPolaganje.IdGrupeZaPolaganje);
            btnStrelicaUNazad.Visible = true;
        }

        private void btnStrelicaUNazad_Click(object sender, EventArgs e)
        {
            lblGrupeZaPolaganje.Text = "Grupe za polaganje";
            dataGridGrupeZaPolaganje.DataSource = controller.VratiGrupeZaPolaganje();
            btnStrelicaUNazad.Visible = false;
        }
    }
}
