namespace Strategy
{
    public class PedidoMoveis : Pedido
    {
        private string _nomeSetor;

        public PedidoMoveis()
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
