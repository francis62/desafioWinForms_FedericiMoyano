using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_MoyanoFederici
{
    public class Pantalon : Prenda
    {
        private bool _esBermuda;

        public Pantalon(bool esBermuda, bool esPremium, double precio) : base(esPremium, precio)
        {
            this._esBermuda = esBermuda;
        }

        public bool EsBermuda
        {
            get { return this._esBermuda; }
        }
    }
}
