namespace DesignPattern.Comportamental.State.Case1
{
    public class EnviadoState : IState
    {
        private Pedido _pedido;

        public EnviadoState(Pedido pedido)
        {
            _pedido = pedido;
        }
        public void CancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago e enviado");
        }

        public void DespacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido já enviado");
        }

        public void SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago e enviado");
        }
    }
}
