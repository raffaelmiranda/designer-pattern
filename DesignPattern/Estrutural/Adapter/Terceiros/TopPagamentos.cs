using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Estrutural.Adapter.Terceiros
{
    public class TopPagamentos
    {
        private float _valor;
        private int _parcelas;
        private string _numeroCartao;
        private string _cvv;

        public void ValorTotal(float valor)
        {
            _valor = valor;
        }

        public void QuantidadeParcelas(int parcelas)
        {
            _parcelas = parcelas;
        }

        public void Cartao(string numeroCartao, string cvv)
        {
            _numeroCartao = numeroCartao;
            _cvv = cvv;
        }

        public bool RealizarPagamento()
        {
            Console.WriteLine("Pagamento realizado via TopPagamentos");

            return true;
        }
    }
}
