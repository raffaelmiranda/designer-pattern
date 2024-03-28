using DesignPattern.Comportamental.TemplateMethod.GatewayPagamento;
using DesignPattern.Comportamental.TemplateMethod.Generico;
using DesignPattern.Comportamental.TemplateMethod.Generico2;

namespace DesignPattern.Comportamental.TemplateMethod
{
    public static class RootTemplateMethod
    {
        public static void Pagamento()
        {
            float valor = 1000f;
            Gateway gateway = new Gateway();

            //Pagamento Crédito
            Console.Write("Crédito: ");
            PagamentoCredito pagamentoCredito = new PagamentoCredito(valor, gateway);
            pagamentoCredito.RealizaCobranca();

            //Pagamento Débito
            Console.Write("Débito: ");
            PagamentoDebito pagamentoDebito = new PagamentoDebito(valor, gateway);
            pagamentoDebito.RealizaCobranca();

            //Pagamento Dinheiro
            Console.Write("Dinheiro: ");
            PagamentoDinheiro pagamentoDinheiro = new PagamentoDinheiro(valor, gateway);
            pagamentoDinheiro.RealizaCobranca();
        }

        public static void Generico()
        {
            Algorithm m = new Algorithm();

            m.TemplateMethod(new ConcreteClassA());
            m.TemplateMethod(new ConcreteClassB());
        }

        public static void Generico2()
        {
            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Client.ClientCode(new ConcreteClass2());
        }
    }
}
