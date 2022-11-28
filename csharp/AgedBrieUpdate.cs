namespace csharp
{
    public class AgedBrieUpdate : DefaultUpdate
    {
        public override void UpdateItem(Item item)
        {
            item.SellIn--;

            item.Quality += item.SellIn < 0 ? 2 : 1;
            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }
}
