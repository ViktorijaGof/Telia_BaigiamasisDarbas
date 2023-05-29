namespace SeleniumFramework.Pages
{
    public class Buttons
    {              
        public static void clickEParduotuve()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[2]";
            Common.Click(locator);
        }

        public static void clickTelefonai()
        {
            string locator = "(//*[contains(@class,'DropdownItemLinkstyles')])[1]";
            Common.Click(locator);
        }
     
        public static void ClickonFirstItem()
        {
            string locator = "(//*[contains(@class,'mobiles-product-card__t')])[1]";
            Common.WaitForElementIsVisible(locator);
            Common.Click(locator);
        }
               
        public static void ScrollAndClickBePlano()
        {
            string locator = "(//*[@data-test='b2c_contract_type_selector']//*[contains(@class,'selector-button-group__variant') and not(contains(@class,'container'))])[2]";
            Common.WaitForElementIsVisible(locator);
            Common.ScrollToBeVisibleAndClick(locator);
        }
        
        public static void clickUzsakytiTelefonaBePlano()
        {
            string locator = "//*[contains(@data-test,'cart-box-action-button')]";
            System.Threading.Thread.Sleep(700);
            Common.Click(locator);
        }

        public static void clickUzsakytiUzsakymoSuvestine()
        {
            string locator = "(//*[contains(@class,'link-icon link-icon--no-float')])[2]";
            Common.WaitForElementIsVisible(locator);
            Common.Click(locator);
        }

        public static void clickPaslaugos()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[1]";
            Common.Click(locator);
        }

        public static void clickInternetas()
        {
            string locator = "(//*[contains(@class,'DropdownItemLinkstyles__DropdownItemText-')])[4]";
            Common.Click(locator);
        }

        public static void ScrollAndClickDaugiau()
        {
            string locator = "(//*[contains(@class,'pt-0 pb-0')])[1]"; 
            Common.ScrollToBeVisibleAndClick(locator);
        }
        
        public static void ClickNeturiu()
        {
            string locator = "(//*[contains(@data-test,'action--button')])[6]";
            System.Threading.Thread.Sleep(700);
            Common.SwitchToWindowByLocator(locator);
            Common.Click(locator);
            Common.WaitForElementIsVisible(locator);
            Common.SwitchToDefaultContetnt();
        }

        public static void ScrollAndClickDomina()
        {
            string locator = "//*[contains(@class,'telia-button telia-button--primary')]";
            Common.WaitForElementIsVisible(locator); 
            Common.ScrollToBeVisibleAndClick(locator);
        }

        public static void clickPagalba()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[4]";
            Common.Click(locator); 
        }
       
        public static void ClickTeliaSalonai()
        {
            string locator = "(//*[contains(@class, 'QuickLinksstyles__QuickLinksAnchor')])[3]";
            Common.WaitForElementIsVisible(locator);
            Common.Click(locator); 
        }

        public static void ClickCityOption()
        {
            string locator = "//*[contains(@class,'retail-search__search-item')]";
            Common.WaitForElementIsVisible(locator); 
            Common.Click(locator);
        }

        public static void ClckFirstStore()
        {
            string locator = "(//*[contains(@class,'card-salon-compact__shop')])[1]";
            Common.WaitForElementIsVisible(locator);
            Common.Click(locator);
        }

        public static void ClickSutrikimai()
        {
            string locator = "(//*[contains(@class,'QuickLinksstyles__QuickLinksLink-sc-totlx2-5 culdSM')])[8]";
            Common.WaitForElementIsVisible(locator); 
            Common.Click(locator);
        }

        public static void ClickNamuInternetas()
        {
            string locator = "(//*[contains(@class,'QuickLinksstyles__QuickLinksLink-sc-totlx2-5 culdSM')])[1]";
            Common.WaitForElementIsVisible(locator); 
            Common.Click(locator); 
        }

        public static void clickLaikrodžiaiIrApyrankės()
        {
            string locator = "(//*[contains(@class,'DropdownItemLinkstyles')])[13]";
            Common.Click(locator);
        }

        public static void ScrollAndCheckJuoda()
        {
            string locator = "(//*[contains(@class,'facet__text')])[13]";
            Common.ScrollToBeVisibleBlackAndClick(locator);
        }
    }
}
