using DesignPattern.Comportamental.Observer.Case1;

namespace DesignPattern.Comportamental.Observer
{
    public static class RootObserver
    {
        public static void Case1()
        {
            Newsletter newsletter = new Newsletter();

            Funcionario funcionario1 = new Funcionario("Funcionario 1", "funcionario1@gmail.com", newsletter);
            Funcionario funcionario2 = new Funcionario("Funcionario 2", "funcionario2@gmail.com", newsletter);

            Cliente cliente = new Cliente("Cliente", "cliente@gmail.com", newsletter);
            Parceiro parceiro = new Parceiro("Parceiro", "parceiro@gmail.com", newsletter);
            Fornecedor fornecedor = new Fornecedor("Fornecedor", "fornecedor@gmail.com", newsletter);

            newsletter.AddMessage("Primeira mensagem");

            Console.WriteLine("************ Observer Funcionario 2 Removido ************");
            newsletter.RemoveObserver(funcionario2);
            newsletter.AddMessage("Segunda mensagem");

            Console.WriteLine("************ Observer Parceiro Removido ************");
            newsletter.RemoveObserver(parceiro);
            newsletter.AddMessage("Terceira mensagem");

            Console.WriteLine("************ Observer Funcionario 2 Registrado ************");
            newsletter.RegisterObserver(funcionario2);
            newsletter.AddMessage("Quarta mensagem");

            Console.WriteLine("************ Notificação para todos os Observers ************");
            newsletter.NotifyObservers();
        }
    }
}
