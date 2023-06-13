using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class FilterByColor : BaseTest
    {
        [Test]
        public void SelectProductTypeAndColor()
        {
            string expectedColorCode = "#222222";

            Buttons.ClickEParduotuve();
            Buttons.ClickLaikrodžiaiIrApyrankės();
            Buttons.CheckColorFilterJuoda();

            Assert.IsTrue(TextBox.CheckThatAllProductsContainExpectedColor(expectedColorCode));
        }
    }
}
