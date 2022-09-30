namespace Strategy.Sort
{
    public class Descending : ISortStrategy
    {
        public List<string> Sort(List<string> list)
        {
            return list.OrderByDescending(x => x).ToList();
        }
    }

}
