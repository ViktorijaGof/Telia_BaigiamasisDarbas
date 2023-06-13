using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    internal class Help : BaseTest
    {
        [Test]
        public void FindInformationAboutAProblem()
        {
            string expectedResult = "Bendra informacija";

            Buttons.ClickPagalba();
            Buttons.ClickSutrikimai();
            Buttons.ClickNamuInternetas();
            string actualResult = TextBox.GetProblemsHeading();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
