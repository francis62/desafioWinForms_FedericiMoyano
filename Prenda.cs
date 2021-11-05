using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_MoyanoFederici
{
    public abstract class Prenda : Producto
    {
        private bool _esPremium;

        public Prenda(bool esPremium, double precio) : base(precio)
        {
            this._esPremium = esPremium;
        }
    }
}
