using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }
        public static void ShutdownDriver()
        {
            driver.Quit();
        }
    }
}
