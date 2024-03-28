using DesignPattern.Comportamental.TemplateMethod.Case1;
using DesignPattern.Comportamental.TemplateMethod.Case2;
using DesignPattern.Comportamental.TemplateMethod.Case3;

namespace DesignPattern.Comportamental.TemplateMethod
{
    public static class RootTemplateMethod
    {
        public static void Case1()
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

        public static void Case2()
        {
            Algorithm m = new Algorithm();

            m.TemplateMethod(new ConcreteClassA());
            m.TemplateMethod(new ConcreteClassB());
        }

        public static void Case3()
        {
            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Client.ClientCode(new ConcreteClass2());
        }
    }
}
