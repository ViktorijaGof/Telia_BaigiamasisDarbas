using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class Stores : BaseTest
    {
        [Test]
        public void FindStoresNameAndAdresss()
        {
            string city = "Vilnius";
            string expectedResult = "Ukmergės g. 369, Vilnius (PC BIG)";

            Buttons.ClickPagalba();
            Buttons.ClickTeliaSalonai();
            TextBox.EnterCity(city);
            Buttons.ClickCityOption();
            Buttons.ClckFirstStore();
            string actualResult = TextBox.GetStoresNameAndAdress();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
