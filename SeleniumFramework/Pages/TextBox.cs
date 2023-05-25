using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    public class TextBox
    {
        public static string GetItemName()

        {                               
            string locator = "//*[contains(@class,'cart-box-product-card__title cart-box-product-card__title--bold')]";
            return Common.GetElementText(locator);

        }

        public static string GetItemPrice()
        {
            string locator = "//*[contains(@class,'fade-enter')]";
            return Common.GetElementText(locator);
        }

        public static string GetServiceRequestHeading()

        {
            string locator = "//*[contains(@class,'form-block__title')]";
            return Common.GetElementText(locator);
        }     
    }
}
