namespace DesignPattern.Comportamental.Strategy.Case1
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
