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
            string expectedResult = "Samsung Galaxy S22";
            Buttons.clickEParduotuve();
            Buttons.clickTelefonai();
            Buttons.ClickonFirstItem();
            Buttons.checkBePlano();
            Buttons.clickUzsakytiTelefonaBePlano();
            Buttons.clickUzsakytiUzsakymoSuvestine();
            string actualResult = TextBox.GetItemName(); 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
