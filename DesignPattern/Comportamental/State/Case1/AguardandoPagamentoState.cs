namespace DesignPattern.Comportamental.State.Case1
{
    public class AguardandoPagamentoState : IState
    {
        private Pedido _pedido;

        public AguardandoPagamentoState(Pedido pedido)
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
            throw new Exception("Operação não suportada, o pedido ainda não foi pago");
        }

        public void SucessoAoPagar()
        {
            _pedido.EstadoAtual(_pedido.Pago);
            Console.WriteLine("Pedido Pago");
        }
    }
}
