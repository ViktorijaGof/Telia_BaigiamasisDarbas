using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class PurchaseAnItem : BaseTest
    {
        [SetUp]

        public void Open()
        {
            Buttons.Open();

        }

        [Test]

        public void AddItemToChart()
        {
            string expectedItemName = "Samsung Galaxy S22";
            string expectedPrice = "634,25";
            Buttons.AcceptCookies(); //sukūrus wait nebeatidaro, tai kol kas naudoju clickAccept
            //Buttons.clickAccept();
            Buttons.clickEParduotuve();
            Buttons.clickTelefonai();
            Buttons.ClickonFirstItem();
            Buttons.checkBePlano();
            Buttons.clickUzsakytiTelefonaBePlano();
            Buttons.clickUzsakytiUzsakymoSuvestine();
            string actualItemName = TextBox.GetItemName();
            string actualPrice  = TextBox.GetItemPrice();
            Assert.AreEqual(expectedItemName, actualItemName);
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
