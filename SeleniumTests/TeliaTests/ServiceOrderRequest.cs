using NUnit.Framework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class ServiceOrderRequest : BaseTest
    {
        [Test]
        public void SelectServiceAndSendOrderRequest()
        {
            string expectedResult = "Gaukite „Telia“ pasiūlymą";
            Buttons.clickPaslaugos();
            Buttons.clickInternetas();
            Buttons.ScrollAndClickDaugiau();
            Buttons.ClickNeturiu();          
            Buttons.ScrollAndClickDomina();
            string actualResult = TextBox.GetServiceRequestHeading();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
