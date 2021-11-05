using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_MoyanoFederici
{
    static class Caja
    {
        public static double Comprar(int cantidad, Producto producto)
        {
            return producto.Precio * cantidad;
        }
    }
}
