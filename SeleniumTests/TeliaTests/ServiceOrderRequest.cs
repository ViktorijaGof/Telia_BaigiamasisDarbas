using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class ServiceOrderRequest : BaseTest
    {
        [SetUp]

        public void Open()
        {            
            Buttons.Open();
        }

        [Test]

        public void SelectServiceAndSendOrderRequest()
        {
            string expectedResult = "Gaukite „Telia“ pasiūlymą";
            Buttons.clickPaslaugos();
            Buttons.clickInternetas();
            Buttons.clickDaugiau();
            Buttons.ClickDomina();
            string actualResult = TextBox.GetServiceRequestHeading();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
