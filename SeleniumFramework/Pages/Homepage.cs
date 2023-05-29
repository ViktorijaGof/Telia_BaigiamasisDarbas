namespace SeleniumFramework.Pages
{
    public class Homepage
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.telia.lt/privatiems");
        }

        public static void AcceptCookies()
        {
            string locator = "//*[contains(@class,'js-cookie-modal-accept-necessary')]";
            Common.Click(locator);
        }

    }
}
