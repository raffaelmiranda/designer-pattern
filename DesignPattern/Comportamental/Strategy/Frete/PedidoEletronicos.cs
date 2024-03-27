namespace DesignPattern.Comportamental.Strategy.Frete
{
    public class PedidoEletronicos : Pedido
    {
        private string _nomeSetor;

        public PedidoEletronicos()
        {
            _nomeSetor = "Eletrônicos";
        }

        public string NomeSetor 
        {
            get { return _nomeSetor; }
            set { _nomeSetor = value; }
        }
    }
}
