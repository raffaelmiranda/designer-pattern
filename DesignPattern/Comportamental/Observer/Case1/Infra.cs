namespace DesignPattern.Comportamental.Observer.Case1
{
    public static class Infra
    {
        public static void EnviarEmail(IObserver observer, string mensagem)
        {
            Console.WriteLine($"Email enviado para {observer.Nome()} - {observer.Email()}");
            Console.WriteLine($"Mensagem: {mensagem}");
            Console.WriteLine(Environment.NewLine);

        }
    }
}
