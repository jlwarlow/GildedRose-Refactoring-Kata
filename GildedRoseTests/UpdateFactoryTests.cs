namespace GildedRoseTests
{
    using csharp;
    using NUnit.Framework;

    [TestFixture]
    public class UpdateFactoryTests
    {
        [Test]
        public void AgedBrie_Should_Return_AgedBrieUpdate()
        {
            // Arrange
            var item = new Item { Name = "Aged Brie" };
            // Act
            var result = UpdateFactory.GetUpdate(item);

            // Assert
            Assert.IsInstanceOf<AgedBrieUpdate>(result);
        }

        [Test]
        public void Sulfuras_Should_Return_SulfurasUpdate()
        {
            // Arrange
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros" };
            // Act
            var result = UpdateFactory.GetUpdate(item);

            // Assert
            Assert.IsInstanceOf<SulfurasUpdate>(result);
        }

        [Test]
        public void Backstage_Should_Return_BackstagePassUpdate()
        {
            // Arrange
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert" };
            // Act
            var result = UpdateFactory.GetUpdate(item);

            // Assert
            Assert.IsInstanceOf<BackstagePassUpdate>(result);
        }

        [Test]
        public void Conjured_Should_Return_ConjuredManaCakeUpdate()
        {
            // Arrange
            var item = new Item { Name = "Conjured Mana Cake" };
            // Act
            var result = UpdateFactory.GetUpdate(item);

            // Assert
            Assert.IsInstanceOf<ConjuredManaCakeUpdate>(result);
        }

        [Test]
        public void AnythingElse_Should_Return_Update()
        {
            // Arrange
            var item = new Item { Name = "Anything else" };
            // Act
            var result = UpdateFactory.GetUpdate(item);

            // Assert
            Assert.IsInstanceOf<DefaultUpdate>(result);
        }
    }
}
