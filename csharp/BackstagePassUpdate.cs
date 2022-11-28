namespace csharp
{
    public class BackstagePassUpdate : DefaultUpdate
    {
        public override void UpdateItem(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn < 10)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }
}
