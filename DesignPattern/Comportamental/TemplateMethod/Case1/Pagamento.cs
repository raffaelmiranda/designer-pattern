namespace DesignPattern.Comportamental.TemplateMethod.Case1
{
    public abstract class Pagamento
    {
        protected float _valor;
        protected Gateway _gateway;

        public Pagamento(float valor, Gateway gateway)
        {
            _valor = valor;
            _gateway = gateway;
        }

        public virtual float CalcularTaxa()
        {
            return 0;
        }

        public abstract float CalcularDesconto();

        //Realiza Cobranca é o template method
        public  bool RealizaCobranca()
        {
            var taxa = CalcularTaxa();
            var desconto = CalcularDesconto();

            float valorFinal = _valor + taxa - desconto;
            Console.Write($" {_valor} + {taxa} - {desconto} = ");

            return _gateway.Cobrar(valorFinal);
        }
    }
}
