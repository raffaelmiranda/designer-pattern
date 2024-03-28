namespace DesignPattern.Comportamental.Observer.Case1
{
    public class Funcionario : IObserver
    {
        private string _nome;
        private string _email;
        private ISubject _subject;

        public Funcionario(string nome, string email, ISubject subject)
        {
            _nome = nome;
            _email = email;
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public string Email()
        {
            return _email;
        }

        public string Nome()
        {
           return _nome;
        }

        public void Update(string mensagem)
        {
            Infra.EnviarEmail(this, mensagem);
        }
    }
}
