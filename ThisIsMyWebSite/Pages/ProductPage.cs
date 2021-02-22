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
    public class ProductPage
    {
        
        public ProductPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "bigpic")]
        IWebElement Photo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#product > div.fancybox-wrap.fancybox-desktop.fancybox-type-image.fancybox-opened > div > div.fancybox-outer > a.fancybox-nav.fancybox-next")]
        IWebElement NextPhoto { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#product > div.fancybox-overlay.fancybox-overlay-fixed > div > div > div.fancybox-outer > a.fancybox-nav.fancybox-prev")]
        IWebElement PreviousPhoto { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#product > div.fancybox-overlay.fancybox-overlay-fixed > div > div > a")]
        IWebElement ClosePhotoGallery { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-default button-plus product_quantity_up']")]
        IWebElement IncrementQuantity { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-default button-minus product_quantity_down']")]
        IWebElement DecrementQuantity { get; set; }

        [FindsBy(How = How.Id, Using = "group_1")]
        IWebElement SizeDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#color_8")]
        IWebElement ColorPick { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='buttons_bottom_block no-print']/a")]
        IWebElement AddToWishlist { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='fancybox-item fancybox-close']")]
        IWebElement ClosePopup { get; set; }

        [FindsBy(How = How.Name, Using = "Submit")]
        IWebElement AddToCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-default button button-medium']")]
        IWebElement ProcessToCheckOutButton { get; set; }


        

        public void ClickOnPhoto()
        {
            Photo.Click();
            Thread.Sleep(1000);
        }

        public void ClickNextPhoto()
        {
            NextPhoto.Click();
            Thread.Sleep(1000);
        }

        public void ClickPreviousPhoto()
        {
            PreviousPhoto.Click();
            Thread.Sleep(1000);
        }

        public void ClosePhoto()
        {
            ClosePhotoGallery.Click();
            Thread.Sleep(1000);
        }

        public void QuantitiyFunc()
        {
            IncrementQuantity.Click();
            Thread.Sleep(500);
            DecrementQuantity.Click();
            Thread.Sleep(500);
        }

        public void ChangeSize()
        {
            SizeDropDown.SelectDropDownList("L");
            Thread.Sleep(1000);

        }

        public void ChangeColor()
        {
            ColorPick.Click();
            Thread.Sleep(1000);
        }

        public void AddWishlist()
        {
            AddToWishlist.Click();
            Thread.Sleep(2000);
            ClosePopup.Click();
            Thread.Sleep(1000);
        }

        public void ClickAddToCart()
        {
            AddToCartButton.Click();
            Thread.Sleep(2000);
        }

        public void Process()
        {
            ProcessToCheckOutButton.Click();
        }

    }
}
