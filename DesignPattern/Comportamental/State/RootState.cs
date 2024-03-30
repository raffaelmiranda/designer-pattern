using DesignPattern.Comportamental.State.Case1;

namespace DesignPattern.Comportamental.State
{
    public static class RootState
    {
        public static void Case1()
        {
            var pedido = new Pedido();
            pedido.RealizarPagamento();
            pedido.DespacharPedido();

        }
    }
}
