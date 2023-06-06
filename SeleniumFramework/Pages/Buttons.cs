namespace SeleniumFramework.Pages
{
    public class Buttons
    {              
        public static void ClickEParduotuve()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[2]";
            Common.Click(locator);
        }

        public static void ClickTelefonai()
        {
            string locator = "(//*[contains(@class,'DropdownItemLinkstyles')])[1]";
            Common.Click(locator);
        }
     
        public static void ClickonFirstItem()
        {
            string locator = "(//*[contains(@class,'mobiles-product-card__t')])[1]";
            Common.WaitForElementToBeVisible(locator);
            Common.Click(locator);
        }
               
        public static void ScrollAndClickBePlano()
        {
            string locator = "(//*[@data-test='b2c_contract_type_selector']//*[contains(@class,'selector-button-group__variant') and not(contains(@class,'container'))])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.ScrollToBeVisibleAndClick(locator);
        }
        
        public static void ClickUzsakytiTelefonaBePlano()
        {
            string locator = "//*[contains(@data-test,'cart-box-action-button')]";
            System.Threading.Thread.Sleep(700);
            Common.Click(locator);
        }

        public static void ClickUzsakytiUzsakymoSuvestine()
        {
            string locator = "(//*[contains(@class,'link-icon link-icon--no-float')])[2]";
            Common.WaitForElementToBeVisible(locator);
            Common.Click(locator);
        }

        public static void ClickPaslaugos()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[1]";
            Common.Click(locator);
        }

        public static void ClickInternetas()
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
            Common.SwitchToFrameByLocator(locator);
            Common.Click(locator);
            Common.WaitForElementToBeVisible(locator);
            Common.SwitchToDefaultContent();
        }

        public static void ScrollAndClickDomina()
        {
            string locator = "//*[contains(@class,'telia-button telia-button--primary')]";
            Common.WaitForElementToBeVisible(locator); 
            Common.ScrollToBeVisibleAndClick(locator);
        }

        public static void ClickPagalba()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[4]";
            Common.Click(locator); 
        }
       
        public static void ClickTeliaSalonai()
        {
            string locator = "(//*[contains(@class, 'QuickLinksstyles__QuickLinksAnchor')])[3]";
            Common.WaitForElementToBeVisible(locator);
            Common.Click(locator); 
        }

        public static void ClickCityOption()
        {
            string locator = "//*[contains(@class,'retail-search__search-item')]";
            Common.WaitForElementToBeVisible(locator); 
            Common.Click(locator);
        }

        public static void ClckFirstStore()
        {
            string locator = "(//*[contains(@class,'card-salon-compact__shop')])[1]";
            Common.WaitForElementToBeVisible(locator);
            Common.Click(locator);
        }

        public static void ClickSutrikimai()
        {
            string locator = "(//*[contains(@class,'QuickLinksstyles__QuickLinksLink-sc-totlx2-5 culdSM')])[8]";
            Common.WaitForElementToBeVisible(locator); 
            Common.Click(locator);
        }

        public static void ClickNamuInternetas()
        {
            string locator = "(//*[contains(@class,'QuickLinksstyles__QuickLinksLink-sc-totlx2-5 culdSM')])[1]";
            Common.WaitForElementToBeVisible(locator); 
            Common.Click(locator); 
        }

        public static void ClickLaikrodžiaiIrApyrankės()
        {
            string locator = "(//*[contains(@class,'DropdownItemLinkstyles')])[13]";
            Common.Click(locator);
        }

        public static void ScrollAndCheckJuoda()
        {
            string locator = "(//*[contains(@class,'facet__text')])[13]";
            Common.ScrollToBeVisibleAndClick(locator, 150, 1000);
        }
    }
}    
