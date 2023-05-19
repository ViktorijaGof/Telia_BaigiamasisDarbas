using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.TeliaTests
{
    public class ServiceOrderRequest
    {
        [SetUp]

        public void SetUp()
        {
            Driver.InitializeDriver();
            Buttons.Open();
        }

        [Test]

        public void SelectServiceAndSendOrderRequest()
        {
            //O KĄ ČIA REIKTŲ PALYGINTI????
            Buttons.clickPaslaugos();
            Buttons.clickInternetas();
            Buttons.clickDaugiau();
            Buttons.ClickDomina();
            //CloseWindow.CloseUserInfoRequestWindow()  sukurti class gal?
        }

        [TearDown]

        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
