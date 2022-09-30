namespace Strategy.Rota
{
    /// <summary>
    /// Concrete Strategy: Classe que inclui algoritmo que implementa IStrategy interface
    /// </summary>
    public class RotaOnibus : IRota
    {
        public string ContruindoRota(string partida, string destino)
        {
            return $"{Environment.NewLine}Partida {partida}{Environment.NewLine}Destino {destino}";
        }
    }
}
