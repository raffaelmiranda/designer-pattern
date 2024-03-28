namespace DesignPattern.Comportamental.TemplateMethod.GatewayPagamento
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito(float valor, Gateway gateway) : 
            base(valor, gateway){ }

        public override float CalcularTaxa()
        {
            return _valor * 0.05f;
        }

        public override float CalcularDesconto()
        {
            if (_valor > 300) return _valor * 0.02f;

            return 0;
        }
    }
}
