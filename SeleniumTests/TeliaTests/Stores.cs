using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class Stores : BaseTest
    {
        [SetUp]

        public void Open()
        {
            Homepage.Open();
            Homepage.AcceptCookies();
        }

        [Test]

        public void FindStoresNameAndAdresss()
        {
            string city = "Vilnius";
            string expectedResult = "Ukmergės g. 369, Vilnius (PC BIG)";
            Buttons.clickPagalba();
            Buttons.ClickTeliaSalonai();
            TextBox.EnterCity(city);
            Buttons.ClickCityOption();
            Buttons.ClckFirstStore();
            string actualResult = TextBox.GetStoresNameAndAdress();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
