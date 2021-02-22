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
    public class CreateAnAccount
    {
        public CreateAnAccount(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='account - creation_form']/div[1]/div[2]/label")]
        IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
         IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
         IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
         IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
         IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
         IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
         IWebElement StateDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
         IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Id, Using = "id_country")]
         IWebElement Country { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
         IWebElement Mobile { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
         IWebElement AddressAlias { get; set; }

        [FindsBy(How = How.Name, Using = "id_state")]
         IWebElement State { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#id_state > option:nth-child(6)")]
         IWebElement StateElement { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#id_country > option:nth-child(2)")]
         IWebElement CountryElement { get; set; }

        [FindsBy(How = How.Name, Using = "submitAccount")]
        public IWebElement SubmitButton { get; set; }


        public void PopulateAccountInfo()
        {
            //Populate values
            FirstName.SendKeys(Config.Credidentials.UserInformations.FirstName);
            Thread.Sleep(300);
            LastName.SendKeys(Config.Credidentials.UserInformations.LastName);
            Thread.Sleep(300);
            Password.SendKeys(Config.Credidentials.UserInformations.Password);
            Thread.Sleep(300);
            Address.SendKeys(Config.Credidentials.UserInformations.Address);
            Thread.Sleep(300);
            City.SendKeys(Config.Credidentials.UserInformations.City);
            Thread.Sleep(300);
            PostalCode.SendKeys(Config.Credidentials.UserInformations.PostalCode);
            Thread.Sleep(300);
            Mobile.SendKeys(Config.Credidentials.UserInformations.Mobile);
            Thread.Sleep(300);
            AddressAlias.SendKeys(Config.Credidentials.UserInformations.AddressAlias);
            Thread.Sleep(300);

            State.SelectDropDownList("Alaska");
            Country.SelectDropDownList("United States");

            //Click Submit button
            SubmitButton.Click();

        }

        



    }
}
