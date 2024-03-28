namespace DesignPattern.Comportamental.Strategy.Case3
{
    public class Descending : ISortStrategy
    {
        public List<string> Sort(List<string> list)
        {
            return list.OrderByDescending(x => x).ToList();
        }
    }

}
