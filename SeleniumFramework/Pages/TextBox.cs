﻿using System;

namespace SeleniumFramework.Pages
{
    public class TextBox
    {
        public static string GetItemName()
        {                               
            string locator = "(//*[contains(@class,'cart-box-product-card__title')])[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static string GetItemPrice()
        {
            string locator = "//*[contains(@class,'fade-enter fade-enter-active cart-box-total-price-block__price')]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static string GetServiceRequestHeading()
        {
            string locator = "//*[contains(@class,'form-block__title')]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static void EnterCity(string city)
        {
            string locator = "(//*[contains(@class,'new-search__input')])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.SendKeys(locator, city);
        }

        public static string GetStoresNameAndAdress()
        {
            string locator = "//*[contains(@class,'card-salon__header')]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);                 
        }

        public static string GetProblemsHeading()
        {
            string locator = "//*[contains(@class,'GroupTitlestyles__')]"; //Nerandu tinkamo lokatoriaus
            Common.WaitForElementToBeVisible(locator); 
            return Common.GetElementText(locator);
        }

        public static string GetColorName()
        {
            string locator = "(//*[contains(@class,'tool tool__remove-filter')])[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static bool CheckThatAllProductsContainExpectedColor(string expectedColorCode)
        {
            string productElementLocator = "//*[contains(@class,'card__product')]";
            string colorElementLocator = $"//*[@class='mobile-color-label ' and @style='background-color:{expectedColorCode}']";
            return Common.CheckThatEachParentElementContainsChildElement(productElementLocator, colorElementLocator);
        }
    }
}
