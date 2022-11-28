using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("foo", items[0].Name);
        }

        [Test]
        public void Brie_Should_Increase_In_Quality()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 5 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(6, items[0].Quality);
        }

        [Test]
        public void Brie_Should_Not_Increase_Above_50()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(50, items[0].Quality);
        }

        [Test]
        public void Sulfuras_Should_Not_Decrease_In_Quality()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(80, items[0].Quality);
        }

        [Test]
        public void Sulfuras_Should_Not_Need_To_Be_Sold()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(10, items[0].SellIn);
        }

        [Test]
        public void Aged_Brie_Should_Update()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 2 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(-1, items[0].SellIn);
            Assert.AreEqual(4, items[0].Quality);
        }

        [Test]
        public void Conjured_Items_Degrade_Faster()
        {
            // Arrange
            var items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            var app = new GildedRose(items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.AreEqual(2, items[0].SellIn);
            Assert.AreEqual(4, items[0].Quality);
        }
    }
}
