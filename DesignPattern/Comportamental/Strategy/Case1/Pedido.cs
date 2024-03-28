namespace DesignPattern.Comportamental.Strategy.Case1
{
    public abstract class Pedido
    {
        private float _valor;
        private IFrete? _frete;

        public float Valor
        {
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
