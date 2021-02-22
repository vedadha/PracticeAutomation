using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsMyWebSite.Pages
{
    public class MyAccountPage
    {
        public MyAccountPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(1) > ul > li:nth-child(1) > a")]
        IWebElement OrderHistory { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(1) > ul > li:nth-child(2) > a")]
        IWebElement MyCreditSlips { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(1) > ul > li:nth-child(3) > a")]
        IWebElement MyAddresses { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(1) > ul > li:nth-child(4) > a")]
        IWebElement PerosnalInformation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(2) > ul > li > a")]
        IWebElement MyWishlists { get; set; }
    }
}
