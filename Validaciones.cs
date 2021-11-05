using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioWinForms_MoyanoFederici
{
    static class Validaciones
    {
        public static bool ComprobarRadioButtons(RadioButton radio1, RadioButton radio2)
        {
            /* Siempre habra que seleccionar entre dos radio buttons, entonces le paso los dos radio buttons por parametro
             * y si ninguno de los dos esta seleccionado, entonces hay que mostrar un error.
             */
            if (! radio1.Checked && ! radio2.Checked)
            {
                return false;
            }
            return true;
        }

        public static bool ComprobarTextBoxNumber(TextBox textBox, char tipoDeNumero)
        {
            if (textBox.Text.Length == 0)
            {
                return false;
            }

            // Si el contenido no es un numero, entonces retorname falso 
            bool esNumero;
            /* debo intentar parsear al tipo de dato que quiero aceptar segun el checkbox
             * i -> int
             * d -> double
             */
            switch (tipoDeNumero)
            {
                case 'i':
                    esNumero = int.TryParse(textBox.Text, out int cantidad);
                    
                    if (! esNumero)
                    {
                        return false;
                    }
                    else if (cantidad <= 0)
                    {
                        return false;
                    }

                    break;
                case 'd':
                    esNumero = double.TryParse(textBox.Text, out double precio);

                    if (! esNumero)
                    {
                        return false;
                    }
                    else if (precio <= 0)
                    {
                        return false;
                    }

                    break;
            }

            return true;
        }
    }
}
