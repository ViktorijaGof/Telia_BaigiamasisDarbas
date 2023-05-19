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
            Buttons.clickEParduotuve();
            Buttons.clickTelefonai();
            string expectedResult = Buttons.GetItemName();
            Buttons.ClickonFirstItem();
            Buttons.checkBePlano();
            Buttons.clickUzsakytiTelefonaBePlano();
            Buttons.clickUzsakytiUzsakymoSuvestine();
            string actualResult = Buttons.GetItemName();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]

        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
