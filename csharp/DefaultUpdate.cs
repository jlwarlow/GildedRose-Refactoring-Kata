namespace csharp
{
    public class DefaultUpdate
    {
        public virtual void UpdateItem(Item item)
        {
            item.SellIn--;

            item.Quality -= item.SellIn < 0 ? 2 : 1;
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
