using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProCast
{
    public class Validering
    {
        public static bool TaBortValidering(Control control)
        {
            DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort detta?", "Bekräfta borttagning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (control is ListBox listBox)
            {
                if (listBox.SelectedIndex != -1)
                {
                    if (result == DialogResult.Yes)
                    {
                        return true;
                    }
                }
            }
            else if (control is ListView listView)
            {
                if (listView.SelectedItems.Count > 0)
                {
                    if (result == DialogResult.Yes)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool TomtFalt(Control control)
        {
            if (control is TextBox textBox)
            {
                return string.IsNullOrEmpty(textBox.Text);
            }

            if (control is ComboBox comboBox)
            {
                return comboBox.SelectedItem == null;
            }

            return false;
        }


    }

}

