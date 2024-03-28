namespace DesignPattern.Comportamental.TemplateMethod.Case1
{
    public class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(float valor, Gateway gateway) : 
            base(valor, gateway){ }

        public override float CalcularDesconto()
        {
            return _valor * 0.01f;
        }
    }
}
