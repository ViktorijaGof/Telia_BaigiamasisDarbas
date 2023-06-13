﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static IList<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator));
        }

        private static IWebElement GetElementInsideParentElement(IWebElement parentElement, string locator)
        {
            return parentElement.FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ScrollToBeVisibleAndClick(string locator, int maxRetryCount = 20, int verticalScrollStepSize = 200)

        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = maxRetryCount;
            int currentTry = 0;

            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch (Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        Driver.GetDriver().ExecuteJavaScript($"window.scrollBy(0, {verticalScrollStepSize})");
                        currentTry++;
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }

        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(15));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Displayed);
        }

        internal static bool CheckThatEachParentElementContainsChildElement(string parentElementLocator, string childElementLocator)
        {
            IList<IWebElement> elements = GetElements(parentElementLocator);

            foreach (IWebElement element in elements)
            {
                try
                {
                    GetElementInsideParentElement(element, childElementLocator);
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            return true;
        }

        internal static void WaitForElementToNotBePresent(string locator)
        {
            int maxRetries = 20;
            int currentTry = 0;
            while(currentTry < maxRetries)
            {
                try
                {
                    GetElement(locator);
                    System.Threading.Thread.Sleep(50);
                    currentTry++;
                }
                catch (NoSuchElementException)
                {
                    return;
                }
                catch (StaleElementReferenceException)
                {
                    return;
                }
            }
        }
    }
}  
