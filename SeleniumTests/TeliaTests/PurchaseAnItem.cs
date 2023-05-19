using NUnit.Framework;


namespace SeleniumTests.TeliaTests
{
    internal class PurchaseAnItem
    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
            Buttons.Open();
        }

        [Test]

        public void AddingItemToChart()
        {

            string expectedResult = "Samsung Galaxy S23+";
            Buttons.clickEParduotuve();
            Buttons.clickTelefonai();
            Buttons.selectFirstItem();
            Buttons.checkBePlano();
            Buttons.clickUzsakytiTelefonaBePlano();
            Buttons.clickUzsakytiUzsakymoSuvestine();
            string actualResult = Buttons.GetText();
            Assert.AreEqual(expectedResult, actualResult);

            Driver.ShutdownDriver();
        }
    }
}
