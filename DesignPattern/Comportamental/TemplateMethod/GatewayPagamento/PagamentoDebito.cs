namespace DesignPattern.Comportamental.TemplateMethod.GatewayPagamento
{
    public class PagamentoDebito : Pagamento
    {
        public PagamentoDebito(float valor, Gateway gateway) : 
            base(valor, gateway){ }

        public override float CalcularTaxa()
        {
            return 4;
        }

        public override float CalcularDesconto()
        {
            return _valor * 0.05f;
        }
    }
}
