
namespace SeleniumFramework.Pages
{
    public class Buttons
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.telia.lt/privatiems");
        }

        internal static void clickEParduotuve()
        {
            //string locator = "/html/body/header/div/div[1]/header/div/div/div/div[2]/div[2]/div/a"; kai nukopijuoju xpath adresą - rodo taip... Rašau maždaug taup //*[@class='LinkItemstyles_LinkAnchor']", bet vieko neranda
            Common.Click(locator);
        }
        internal static void clickTelefonai()
        {
            //pvz.: string locator = "//*[@class='cb1-element']";
            Common.Click(locator);
        }

        internal static void selectFirstItem()
        {
            //string locator = "//*[@class='cb1-element']";
            Common.Click(locator);
        }

        internal static void checkBePlano()
        {
            //throw new NotImplementedException();
        }

        internal static string GetText()
        {
            //throw new NotImplementedException();
        }

        public static void clickUzsakytiTelefonaBePlano()
        {
            //string locator = "//*[@class='cb1-element']";
            Common.Click(locator);
        }

        public static void clickUzsakytiUzsakymoSuvestine()
        {
            //string locator = "//*[@class='cb1-element']";
            Common.Click(locator);
        }
}
