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
            lblVoznje.BackColor = System.Drawing.Color.Transparent;
            voznje = controller.VratiVoznje();
        }

        private void UCVoznja_Load(object sender, EventArgs e)
        {
            dataGridVoznje.DataSource = voznje;
        }
    }
}
