using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;

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
        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-screenshot.png";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}", ScreenshotImageFormat.Png);

            return screenshotFilePath;
        }
    }
}
