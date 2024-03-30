namespace DesignPattern.Comportamental.State.Case1
{
    public class PagoState : IState
    {
        private Pedido _pedido;

        public PagoState(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void CancelarPedido()
        {
            _pedido.EstadoAtual(_pedido.Cancelado);
            Console.WriteLine("Pedido Cancelado");
        }

        public void DespacharPedido()
        {
            _pedido.EstadoAtual(_pedido.Enviado);
            Console.WriteLine("Pedido Enviado");
        }

        public void SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago");
        }
    }
}
