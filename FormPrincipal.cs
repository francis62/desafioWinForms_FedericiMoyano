using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioWinForms_MoyanoFederici
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCalcularPrecioFinal_Click(object sender, EventArgs e)
        {
            bool esTodoValido = ValidarFormulario();
            
            if (esTodoValido)
            {
                MostrarProductoCalculado();
                MostrarCantidadCalculada();
                CalcularPrecioFinal();
            }
        }

        private bool ValidarFormulario()
        {
            bool radioTipoPrendaEsValido = Validaciones.ComprobarRadioButtons(rdBtnCamisa, rdBtnPantalon);
            if (! radioTipoPrendaEsValido)
            {
                MostrarPopupError("Debes seleccionar un tipo de prenda");
                return false;
            }

            bool radioCalidadPrendaEsValido = Validaciones.ComprobarRadioButtons(rdBtnPrendaNoPremium, rdBtnPrendaPremium);
            if (! radioCalidadPrendaEsValido)
            {
                MostrarPopupError("Debes seleccionar la calidad de la prenda");
                return false;
            }

            bool precioEsValido = Validaciones.ComprobarTextBoxNumber(txtBoxPrecioProducto, 'd');
            if (! precioEsValido)
            {
                MostrarPopupError("El precio ingresado no es un número válido");
                return false;
            }

            bool cantidadEsValida = Validaciones.ComprobarTextBoxNumber(txtBoxCantidadProducto, 'i');
            if (! cantidadEsValida)
            {
                MostrarPopupError("La cantidad que ingresaste no es un número válido");
                return false;
            }

            return true;
        }

        private void MostrarProductoCalculado()
        {
            string productoCalculado = "";

            if (rdBtnCamisa.Checked)
            {
                productoCalculado = GenerarStringCamisa();
            }
            else if (rdBtnPantalon.Checked)
            {
                productoCalculado = GenerarStringPantalon();
            }
            
            labelProducto.Text = productoCalculado;
        }

        private void MostrarCantidadCalculada()
        {
            labelCantidad.Text = txtBoxCantidadProducto.Text;
        }

        private void CalcularPrecioFinal()
        {
            Caja caja = new Caja();
            double precioFinal = 0;

            // int.Parse y double.Parse no generaran error porque ya los valide anteriormente
            int cantidadPrendas = int.Parse(txtBoxCantidadProducto.Text);
            double precioUnitario = Convert.ToDouble(txtBoxPrecioProducto.Text);

            bool prendaEsPremium = rdBtnPrendaPremium.Checked ? true : false;

            if (rdBtnCamisa.Checked)
            {
                bool camisaEsMangaCorta = chBoxCamisaMangaCorta.Checked;
                Camisa camisa = new Camisa(camisaEsMangaCorta, prendaEsPremium, precioUnitario);
                precioFinal = caja.ComprarPrendas(cantidadPrendas, camisa);
                precioFinal = caja.CalcularPrecioFinal(precioFinal, camisa);
            }
            else if (rdBtnPantalon.Checked)
            {
                bool pantalonEsBermuda = chBoxPantalonBermuda.Checked;
                Pantalon pantalon = new Pantalon(pantalonEsBermuda, prendaEsPremium, precioUnitario);
                precioFinal = caja.ComprarPrendas(cantidadPrendas, pantalon);
                precioFinal = caja.CalcularPrecioFinal(precioFinal, pantalon);
            }

            labelPrecioFinal.Text = String.Format("{0:0.00}", precioFinal);
        }

        private string GenerarStringCamisa()
        {
            string stringParaLabelProducto = "Camisa";

            if (chBoxCamisaMangaCorta.Checked)
            {
                return stringParaLabelProducto + " manga corta";
            }
            return stringParaLabelProducto + " manga larga";
        }

        private string GenerarStringPantalon()
        {
            string stringParaLabelProducto = "Pantalón";

            if (chBoxPantalonBermuda.Checked)
            {
                return stringParaLabelProducto + " tipo bermuda";
            }
            return stringParaLabelProducto + " largo";
        }

        private void MostrarPopupError(string mensaje)
        {
            System.Windows.Forms.MessageBox.Show(mensaje, "Error");
        }
    }
}
