using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaDeBar
{
    class Conta
    {
        public List<ItemConta> cart = new List<ItemConta>();

        public int  QtdPessoa;
        public bool TaxaDez; 

        public void SetQtdPessoa(int qtdPessoa)
        {
            QtdPessoa = qtdPessoa;
        }

        public void Taxa(bool lTaxa)
        {
            TaxaDez = lTaxa;
        }

        public double ValorPorPessoa()
        {
            return CalcTotal() / QtdPessoa;
        }

        public double CalcTotal()
        {
            double Total = 0;
            for (int x = 0; x < cart.Count; x++)
            {
                Total = Total + cart[x].TotalItem();
            }

            if (TaxaDez)
            {
                return Total * 1.1;
            }
            else
            {
                return Total;
            }

        }
        public void AdicionarItem(int qtd, double valorUnit)
        {
            ItemConta conta = new ItemConta();
            conta.Quantidade = qtd;
            conta.ValorUnitario = valorUnit;

            this.cart.Add(conta);
        }

    }

}

