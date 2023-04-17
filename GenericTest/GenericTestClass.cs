namespace GenericTest
{
    public class GenericTestClass<T> where T : struct
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public List<T> GetDescendingItems()
        {
            items.Sort();
            items.Reverse();
            return items;
        }
    }
}