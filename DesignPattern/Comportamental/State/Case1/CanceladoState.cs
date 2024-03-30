namespace DesignPattern.Comportamental.State.Case1
{
    public class CanceladoState : IState
    {
        private Pedido _pedido;

        public CanceladoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void CancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido já se encontra cancelado");
        }

        public void DespacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido se encontra cancelado");
        }

        public void SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido se encontra cancelado");
        }
    }
}
