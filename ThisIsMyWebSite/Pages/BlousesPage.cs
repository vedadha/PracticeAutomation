using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThisIsMyWebSite.Pages
{
    public class BlousesPage
    {
        public BlousesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#center_column > ul > li > div > div.right-block > h5 > a")]
        IWebElement Blouse { get; set; }

        public void ClickOnProduct()
        {
            Blouse.Click();
            Thread.Sleep(3000);
        }
    }
}
