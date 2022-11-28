namespace csharp
{
    public static class UpdateFactory
    {
        public static DefaultUpdate GetUpdate(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrieUpdate();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasUpdate();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassUpdate();
                case "Conjured Mana Cake":
                    return new ConjuredManaCakeUpdate();
                default:
                    return new DefaultUpdate();
            }
        }
    }
}
