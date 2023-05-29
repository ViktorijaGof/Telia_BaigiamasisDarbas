using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class PurchaseAnItem : BaseTest
    {
        [SetUp]

        public void Open()
        {
            Homepage.Open();
            Homepage.AcceptCookies();
        }

        [Test]

        public void AddItemToCart()
        {
            string expectedItemName = "Samsung Galaxy S22";
            string expectedPrice = "634,25 €";
            Buttons.clickEParduotuve();
            Buttons.clickTelefonai();
            Buttons.ClickonFirstItem();
            Buttons.ScrollAndClickBePlano();
            Buttons.clickUzsakytiTelefonaBePlano();
            string actualItemName = TextBox.GetItemName();
            string actualPrice  = TextBox.GetItemPrice();
            Buttons.clickUzsakytiUzsakymoSuvestine();
            Assert.AreEqual(expectedItemName, actualItemName);
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
