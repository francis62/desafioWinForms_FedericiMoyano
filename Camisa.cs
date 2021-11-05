using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_MoyanoFederici
{
    public class Camisa : Prenda
    {
        private bool _esMangaCorta;

        public Camisa(bool esMangaCorta, bool esPremium, double precio) : base(esPremium, precio)
        {
            this._esMangaCorta = esMangaCorta;
        }
    }
}
