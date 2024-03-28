namespace DesignPattern.Comportamental.Strategy.Case1
{
    public class FreteComum : IFrete
    {
        public float Calcular(float valorPedido)
        {
            return valorPedido * 0.05f;
        }
    }
}
