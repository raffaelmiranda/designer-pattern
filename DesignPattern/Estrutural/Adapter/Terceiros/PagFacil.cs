namespace DesignPattern.Estrutural.Adapter.Terceiros
{
    public class PagFacil
    {
        private float _valor;
        private int _parcelas;
        private string _numeroCartao;
        private string _cvv;

        public void Valor(float valor)
        {
            _valor = valor;
        }

        public void Parcelas(int parcelas)
        {
            _parcelas = parcelas;
        }

        public void NumeroCartao(string numeroCartao)
        {
            _numeroCartao = numeroCartao;
        }

        public void Cvv(string cvv)
        {
            _cvv = cvv;
        }

        public bool ValidarCartao()
        {
            if (_numeroCartao != string.Empty &&
               _cvv != string.Empty &&
               _cvv.Length == 3)
                return true;
            else
                return false;
        }

        public bool RealizarPagamento()
        {
            Console.WriteLine("Pagamento realizado via PagFacil");

            return true;
        }
    }
}
