namespace DesignPattern.Comportamental.Observer.Case1
{
    public class Newsletter: ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private List<string> _mensagens = new List<string>();

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Update(_mensagens.Last());
            }
        }

        public void AddMessage(string message)
        {
            _mensagens.Add(message);

            NotifyObservers();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
