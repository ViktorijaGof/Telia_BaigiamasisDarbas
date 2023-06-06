using NUnit.Framework.Interfaces;
using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages;

namespace SeleniumTests.TeliaTests
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Homepage.Open();
            Homepage.AcceptCookies();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
            Driver.ShutdownDriver();
        }
    }
}
