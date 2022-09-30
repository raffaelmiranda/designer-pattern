namespace Strategy
{
    public abstract class Pedido
    {
        private float _valor;
        private IFrete? _frete;

        public float Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public void Frete(IFrete frete)
        {
           _frete = frete;
        }
  
        public float? CalcularFrete()
        {
            return _frete?.Calcular(_valor);
        }
    }
}
