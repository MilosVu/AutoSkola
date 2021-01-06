using Domain;
using Forme.Controller;
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

        
        private ControllerVoznja controllerVoznja;

        public UCVoznja(Controller.ControllerVoznja controllerVoznja)
        {
            InitializeComponent();
            this.controllerVoznja = controllerVoznja;
        }

        private void UCVoznja_Load(object sender, EventArgs e)
        {
            controllerVoznja.NapuniCbKategorije(cbKategorija);
            controllerVoznja.NapuniDataGridVoznje(dataGridVoznje);
        }

        private void btnKreirajVoznju_Click(object sender, EventArgs e)
        {
            controllerVoznja.OtvoriDialogKreirajVoznju();
        }

        private void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            controllerVoznja.PromenaKategorije(cbKategorija, dataGridVoznje);
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            controllerVoznja.FiltrirajPretragu(dataGridVoznje,txtPretraga);
        }

        

    }
}
