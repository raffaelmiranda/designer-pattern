namespace DesignPattern.Comportamental.Strategy.Case2
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class RotaCarro : IRota
    {
        public string ContruindoRota(string partida, string destino)
        {
            return $"{Environment.NewLine}Partida {partida}{Environment.NewLine}Destino {destino}";
        }
    }
}
