using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_MoyanoFederici
{
    public abstract class Producto
    {
        private double _precio;

        public Producto(double precio)
        {
            this._precio = precio;
        }

        public double Precio
        {
            get { return this._precio; }
        }
    }
}
