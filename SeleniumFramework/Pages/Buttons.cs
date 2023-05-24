
using System;
using System.Net.NetworkInformation;

namespace SeleniumFramework.Pages
{
    public class Buttons
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.telia.lt/privatiems");
        }


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
            Common.Click(locator);
        }

        public static void checkBePlano()
        {
            string locator = "((//*[contains(@class,'selector-button-group__variant ')])[2]";
            Common.Click(locator);
        }              

        public static void clickUzsakytiTelefonaBePlano()
        {
            string locator = "(//*[contains(@class,'link-icon__text')])[2]";
            Common.Click(locator);
        }

        public static void clickUzsakytiUzsakymoSuvestine()
        {
            string locator = "(//*[contains(@class,'link-icon link-icon--no-float')])[2]";
            Common.Click(locator);
        }

        public static void clickPaslaugos()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[1]";
            Common.Click(locator);
        }

        public static void clickInternetas()
        {
            string locator = "((//*[contains(@class,'DropdownItemLinkstyles__DropdownItemText-')])[4]";
            Common.Click(locator);
        }

        public static void clickDaugiau()
        {
            string locator = "(//*[contains(@class,'btn btn-primary')])[1]";
            Common.Click(locator);
        }

        public static void ClickDomina()
        {
            string locator = "(//*[contains(@class,'telia-button')])[1]";
            Common.Click(locator);
        }

        public static void clickPagalba()
        {
            string locator = "(//*[contains(@class,'LinkItemstyles__LinkAnchor')])[4]";
            Common.Click(locator); 
        }

        public static void clickSutartysIrSaskaitos()
        {
            string locator = "(//*[contains(@class,'QuickLinksstyles__QuickLinksLink')])[5]";
            Common.Click(locator);
        }

        public static void ClickPaslauguTeikimoDokumentai()
        {
            string locator = "//*[contains(@class,'QuickLinksstyles__QuickLinksLink')])[1]";
            Common.Click(locator);
        }
              
        public static void GaliojantysNamuInternetoPaslauguTeikimoDokumentai()
        {
            string locator = "//*[contains(@class,'ExpandableGroupstyles__ExpandableGroupCh')])[1]";
            Common.Click(locator);
        }

        public static void clickFirstHyperlinkBelowPaslauguteikimoDokumentai()
        {
            string locator = "//*[@id='paslaugu-teikimo-dokumentai']/div/ul/li[1]/a";
            Common.Click(locator);
        }
    }
}
