using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    internal class Help
    {
        [SetUp]

        public void Open()
        {
            Homepage.Open();
            Homepage.AcceptCookies();
        }

        [Test]

        public void FindInformationAboutAProblem()
        {
            string expectedResult = "Bendra informacija";
            Buttons.clickPagalba();
            Buttons.ClickSutrikimai();
            Buttons.ClickNamuInternetas();
            string actualResult = TextBox.GetProblemsHeading();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
