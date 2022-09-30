namespace Strategy
{
    public class FreteComum : IFrete
    {
        public float Calcular(float valorPedido)
        {
            return valorPedido * 0.05f;
        }
    }
}
