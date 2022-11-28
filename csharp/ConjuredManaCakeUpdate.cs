namespace csharp
{
    public class ConjuredManaCakeUpdate : DefaultUpdate
    {
        public override void UpdateItem(Item item)
        {
            item.SellIn--;

            item.Quality -= item.SellIn < 0 ? 4 : 2;
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
