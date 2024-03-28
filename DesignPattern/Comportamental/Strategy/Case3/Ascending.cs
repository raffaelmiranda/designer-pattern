namespace DesignPattern.Comportamental.Strategy.Case3
{
    public class Ascending : ISortStrategy
    {
        public List<string> Sort(List<string> list)
        {
            return list.OrderBy(x => x).ToList();
        }
    }
}
