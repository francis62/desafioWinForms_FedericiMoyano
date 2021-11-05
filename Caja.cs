using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_MoyanoFederici
{
    class Caja : ICalculadoraCamisas, ICalculadoraPantalones
    {
        private double Comprar(int cantidad, Producto producto)
        {
            return producto.Precio * Convert.ToDouble(cantidad);
        }

        public double ComprarPrendas(int cantidad, Prenda prenda)
        {
            double precioFinal = Comprar(cantidad, prenda);

            return prenda.EsPremium ? precioFinal + (precioFinal * 30.0 / 100.0) : precioFinal;
        }

        public double CalcularPrecioFinal(double precioFinal, Camisa camisa)
        {
            return camisa.EsMangaCorta ? precioFinal - (precioFinal * 10.0 / 100.0) : precioFinal;
        }

        public double CalcularPrecioFinal(double precioFinal, Pantalon pantalon)
        {
            return pantalon.EsBermuda ? precioFinal - (precioFinal * 20.0 / 100.0) : precioFinal;
        }
    }
}
