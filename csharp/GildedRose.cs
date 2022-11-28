namespace csharp
{
    using System.Collections.Generic;

    public class GildedRose
    {
        readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in this._items)
            {
                var update = UpdateFactory.GetUpdate(item);
                update.UpdateItem(item);
            }
        }
    }
}
