namespace Strategy
{
    internal class FreteExpresso : IFrete
    {
        public float Calcular(float valorPedido)
        {
            return valorPedido * 0.1f;
        }
    }
}
