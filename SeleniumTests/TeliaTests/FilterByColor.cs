using NUnit.Framework;
using SeleniumFramework.Pages;
namespace SeleniumTests.TeliaTests
{
    public class FilterByColor : BaseTest
    {
        [Test]
        public void SelectProductTypeAndColor()

        {
            string expectedColor = "Juoda";
            Buttons.clickEParduotuve();
            Buttons.clickLaikrodžiaiIrApyrankės();
            Buttons.ScrollAndCheckJuoda();
            string actualColor = TextBox.GetColorName();
            Assert.AreEqual(expectedColor, actualColor);
        }

    }
}
