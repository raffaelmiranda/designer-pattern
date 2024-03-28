namespace DesignPattern.Comportamental.Observer.Case1
{
    public static class Infra
    {
        //public static void EnviarEmail(IObserver observer, string mensagem)
        public static void EnviarEmail(string nome, string email, string mensagem)
        {
            Console.WriteLine("----------");
            Console.WriteLine($"Email enviado para {nome} - {email}");
            Console.WriteLine($"Mensagem: {mensagem}");

        }
    }
}
