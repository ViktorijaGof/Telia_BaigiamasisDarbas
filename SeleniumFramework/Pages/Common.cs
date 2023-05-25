using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        //internal static void WaitForElementToBeVisible(string locator)
       // {
            //System.Threading.Thread.Sleep(700);
            //WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(7));
            //wait.Until(d => d.FindElement(By.XPath(locator)).Displayed);         
        //}
    }
}
