using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vital.util
{
    class ManipulaCampos
    {
        public static string retiraFormatacaoMoeda(string valor)
        {
            String x = "";
            for (int i = 0; i <= valor.Length - 1; i++)
            {
                if ((valor[i] >= '0' &&
                    valor[i] <= '9') ||
                    valor[i] == ',')
                {
                    x += valor[i];
                }
            }
            return x;

        }

        public static string formataValorMoeda(string valor)
        {
            if (valor != "")
            {
                valor = Convert.ToDouble(valor).ToString("C");
            }
            return valor;
        }

        public static void LimparCampos(Control parent)
        {
            foreach (Control arrControles in parent.Controls)
            {
                if (arrControles is TextBox)
                {
                    TextBox controleALimpar = (TextBox)arrControles;
                    controleALimpar.Text = "";
                }
                else if (arrControles is ComboBox)
                {
                    ComboBox controleALimpar = (ComboBox)arrControles;
                    controleALimpar.SelectedIndex = 0;
                }
                else if (arrControles is CheckBox)
                {
                    CheckBox controleALimpar = (CheckBox)arrControles;
                    controleALimpar.Checked = false;
                }
                else if (arrControles is MaskedTextBox)
                {
                    MaskedTextBox controleALimpar = (MaskedTextBox)arrControles;
                    controleALimpar.Text = "";
                }
                else if (arrControles is ListBox)
                {
                    ListBox controleALimpar = (ListBox)arrControles;
                    controleALimpar.Items.Clear();
                }
                /*else if (arrControles is DateTimePicker)
                {
                    DateTimePicker controleALimpar = (DateTimePicker)arrControles;
                    controleALimpar.Text = DateTime.Now.ToString();
                }*/
                else if (arrControles is PictureBox)
                {
                    PictureBox controleALimpar = (PictureBox)arrControles;
                    controleALimpar.Image = null;
                }
            }
        }
    }
}
