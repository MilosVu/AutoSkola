using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormeHelpers
{
    public class FormeHelper
    {

        public static bool TextFieldValidator(TextBox[] textBoxes)
        {
            bool validate = true;
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.BackColor = Color.Red;
                    validate = false;
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
            return validate;
        }

        public static void PostaviPozadinuTransparentnu(Label[] labels)
        {
            foreach (var label in labels)
            {
                label.BackColor = System.Drawing.Color.Transparent;
            }
        }

        public static void PopuniComboBoxKategorijeDataGrid(DataGridViewComboBoxColumn cbKategorija)
        {
            cbKategorija.Items.Add(Kategorija.A);
            cbKategorija.Items.Add(Kategorija.B);
            cbKategorija.Items.Add(Kategorija.C);
            cbKategorija.Items.Add(Kategorija.D);
        }

        public static void PopuniComboBoxKategorije(ComboBox cbKategorija)
        {
            cbKategorija.DataSource = new Kategorija[] { Kategorija.A, Kategorija.B, Kategorija.C, Kategorija.D };
        }
    }
}
