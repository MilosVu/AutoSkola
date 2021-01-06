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
    public class ControllerGrupaZaPolaganje
    {

        internal static BindingList<GrupaZaPolaganje> grupeZaPolaganje;

        public bool KreirajGrupuZaPolaganje(List<Polaznik> polaznici, GrupaZaPolaganje grupaZaPolaganje)
        {
            throw new NotImplementedException();
        }

        public void VratiGrupeZaPolaganje()
        {
            grupeZaPolaganje = new BindingList<GrupaZaPolaganje>(new List<GrupaZaPolaganje>(
                Communication.Communication.Instance.VratiListu().Cast<GrupaZaPolaganje>()));
        }

        public BindingList<Polaznik> VratiPolaznikaIGrupeZaPolaganje(int idGrupeZaPolaganje)
        {
            return new BindingList<Polaznik>(new List<Polaznik>(
                Communication.Communication.Instance.VratiListu().Cast<Polaznik>()));
        }

        internal void NapuniDataGridGrupeZaPolaganje(DataGridView dataGridGrupeZaPolaganje)
        {
            dataGridGrupeZaPolaganje.DataSource = grupeZaPolaganje;
        }

        internal void OtvoriGrupuZaPolaganje(DataGridView dataGridGrupeZaPolaganje, Label lblGrupeZaPolaganje, Button btnStrelicaUNazad)
        {
            GrupaZaPolaganje grupaZaPolaganje =  (dataGridGrupeZaPolaganje.CurrentRow.DataBoundItem as GrupaZaPolaganje);
            lblGrupeZaPolaganje.Text = $"Grupa za polaganje: {grupaZaPolaganje.IdGrupeZaPolaganje}";
            dataGridGrupeZaPolaganje.DataSource = VratiPolaznikaIGrupeZaPolaganje(grupaZaPolaganje.IdGrupeZaPolaganje);
            btnStrelicaUNazad.Visible = true;
        }

        internal void StrelicaUNazad(DataGridView dataGridGrupeZaPolaganje, Label lblGrupeZaPolaganje, Button btnStrelicaUNazad)
        {
            lblGrupeZaPolaganje.Text = "Grupe za polaganje";
            dataGridGrupeZaPolaganje.DataSource = grupeZaPolaganje;
            btnStrelicaUNazad.Visible = false;
        }
    }
}
