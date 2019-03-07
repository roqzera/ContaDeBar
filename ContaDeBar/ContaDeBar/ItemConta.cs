using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDeBar
{
    class ItemConta
    {
        public int Quantidade;
        public double ValorUnitario;

        public double TotalItem()
        {
            return Quantidade * ValorUnitario;
        }
    }
}
