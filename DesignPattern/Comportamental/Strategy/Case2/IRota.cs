namespace DesignPattern.Comportamental.Strategy.Case2
{
    /// <summary>
    /// Strategy: Define uma interface comum para todas as strategies
    /// </summary>
    public interface IRota
    {
        string ContruindoRota(string partida, string destino);
    }
}
