namespace Strategy.Rota
{

    /// <summary>
    /// Context : Uma classe que mantém informações contextuais para um IStrategy algoritmo do bject para trabalhar
    /// </summary>
    public class Navegacao
    {
        private IRota? _rota;

        private string? _partida;
        private string? _destino;

        public string? Partida
        {
            get { return _partida; }
            set { _partida = value; }
        }

        public string? Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        public void Rota(IRota rota)
        {
            _rota = rota;
        }

        public string? ContruirRota()
        {
           return _rota?.ContruindoRota(_partida, _destino);
        }
    }
}
