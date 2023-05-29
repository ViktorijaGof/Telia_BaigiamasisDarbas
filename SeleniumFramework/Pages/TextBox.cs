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
            string locator = "//*[contains(@class,'fade-enter fade-enter-active cart-box-total-price-block__price')]";
            return Common.GetElementText(locator);
        }

        public static string GetServiceRequestHeading()

        {
            string locator = "//*[contains(@class,'form-block__title')]";
            Common.SwitchToWindowByLocator(locator);
            Common.WaitForElementIsVisible(locator);
            string requestHeading = Common.GetElementText(locator);
            Common.SwitchToDefaultContetnt(); 
            return requestHeading;
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
            string locator = "//*[contains(@class,'GroupTitlestyles__')]"; //Nerandu tinkamo lokatoriaus
            Common.WaitForElementIsVisible(locator); 
            return Common.GetElementText(locator);
        }

        public static string GetColorName()
        {
            string locator = "(//*[contains(@class,'tool tool__remove-filter')])[1]";
            Common.WaitForElementIsVisible(locator);
            return Common.GetElementText(locator);
        }     
    }
}
