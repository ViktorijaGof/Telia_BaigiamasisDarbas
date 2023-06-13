using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class PurchaseAnItem : BaseTest
    {
        [Test]
        public void AddItemToCart()
        {
            string expectedItemName = "Samsung Galaxy S22";
            string expectedPrice = "634,25 €";

            Buttons.ClickEParduotuve();
            Buttons.ClickTelefonai();
            Buttons.ClickonFirstItem();
            Buttons.ScrollAndClickBePlano();
            Buttons.ClickUzsakytiTelefonaBePlano();
            string actualItemName = TextBox.GetItemName();
            string actualPrice  = TextBox.GetItemPrice();
            Buttons.ClickUzsakytiUzsakymoSuvestine();

            Assert.AreEqual(expectedItemName, actualItemName);
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
