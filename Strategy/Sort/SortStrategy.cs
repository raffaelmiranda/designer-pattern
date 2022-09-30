namespace Strategy.Sort
{
    public class SortStrategy
    {
        private ISortStrategy _sortStrategy;
        public SortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }
        public List<string> Sort(List<string> list)
        {
            return _sortStrategy.Sort(list);
        }
    }

}
