using Domain;
using Forme.Controller;
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
        private ControllerGrupaZaPolaganje controllerGrupaZaPolaganje;

        public UCGrupaZaPolaganje(ControllerGrupaZaPolaganje controllerGrupaZaPolaganje)
        {
            InitializeComponent();
            this.controllerGrupaZaPolaganje = controllerGrupaZaPolaganje;
        }

        private void UCGrupaZaPolaganje_Load(object sender, EventArgs e)
        {
            
            controllerGrupaZaPolaganje.NapuniDataGridGrupeZaPolaganje(dataGridGrupeZaPolaganje);
        }

        private void dataGridGrupeZaPolaganje_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controllerGrupaZaPolaganje.OtvoriGrupuZaPolaganje(dataGridGrupeZaPolaganje, 
                lblGrupeZaPolaganje, btnStrelicaUNazad);
        }

        private void btnStrelicaUNazad_Click(object sender, EventArgs e)
        {
            controllerGrupaZaPolaganje.StrelicaUNazad(dataGridGrupeZaPolaganje, lblGrupeZaPolaganje, btnStrelicaUNazad);
        }
    }
}
