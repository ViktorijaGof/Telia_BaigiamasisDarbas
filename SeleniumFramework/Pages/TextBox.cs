using System;

namespace SeleniumFramework.Pages
{
    public class TextBox
    {
        public static string GetItemName()

        {                               
            string locator = "(//*[contains(@class,'cart-box-product-card__title')])[1]";
            return Common.GetElementText(locator);

        }

        public static string GetItemPrice()
        {
            string locator = "//*[contains(@class,'fade-enter fade-enter-active cart-box-total-price-block__price')]";//PAKLAUSTI Del 6ito: kodel ima 5.25 autorin5 mokest5?
            return Common.GetElementText(locator);
        }

        public static string GetServiceRequestHeading()

        {
            string locator = "//*[contains(@class,'form-block__title')]";
            return Common.GetElementText(locator);
        }

        public static void EnterCity(string city)
        {
            string locator = "(//*[contains(@class,'new-search__input')])[2]";
            Common.SendKeys(locator,city);
        }

        public static string GetStoresNameAndAdress()
        {
            string locator = "//*[contains(@class,'card-salon__header')]";
            return Common.GetElementText(locator);                 
        }

        public static string GetProblemsHeading()
        {
            string locator = "//*[contains(@class='GroupTitlestyles__GroupTitle-sc-1w6b7v2-0 TopicGroupstyles__TopicGroupTitle-sc-pnvx8x-0 ELxex bcJeni telia-heading--title-100 hydrated')]"; //Nerandu tinkamo lokatoriaus
            Common.WaitForElementIsVisible(locator); 
            return Common.GetElementText(locator);
        }

        public static string GetColorName()
        {
            string locator = "(//*[contains(@class,'tool tool__remove-filter')])[1]";
            return Common.GetElementText(locator);
        }     
    }
}
