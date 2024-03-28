using DesignPattern.Comportamental.Observer.Case1;

namespace DesignPattern.Comportamental.Observer
{
    public static class RootObserver
    {
        public static void Case1()
        {
            Newsletter newsletter = new Newsletter();

            Funcionario funcionario1 = new Funcionario("Funcionario 1", "funcionario1@gmail.com", newsletter);
            Funcionario funcionario2 = new Funcionario("Funcionario 2", "funcionario1@gmail.com", newsletter);

            Cliente cliente1 = new Cliente("cliente1", "cliente1@gmail.com", newsletter);

            Parceiro parceiro1 = new Parceiro("parceiro1", "parceiro1@gmail.com", newsletter);

            Fornecedor fornecedor1 = new Fornecedor("fornecedor1", "fornecedor1@gmail.com", newsletter);

            newsletter.AddMessage("Primeira mensagem");
        }
    }
}
