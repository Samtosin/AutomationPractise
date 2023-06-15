using OpenQA.Selenium;
using PetStore.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.PageObject
{
    internal class SamsungPage
    {
        public IWebDriver driver;

        public SamsungPage()
        {
            driver = WebHooks.driver;
        }

        private By nokia = By.XPath("//a[normalize-space()='Nokia lumia 1520']");
        private By addtocart = By.XPath("//*[@id=\"tbodyid\"]/div[2]/div/a");
        private By cart = By.XPath("//*[@id=\"navbarExample\"]/ul/li[4]/a");
        private By order = By.XPath("//*[@id=\"page-wrapper\"]/div/div[2]/button");
        private By name = By.XPath("//*[@id=\"name\"]");
        private By countryy = By.XPath("//*[@id=\"country\"]");
        private By city = By.XPath("//*[@id=\"city\"]");
        private By credit = By.XPath("//*[@id=\"card\"]");
        private By monthh = By.XPath("//*[@id=\"month\"]");
        private By yearr = By.XPath("//*[@id=\"year\"]");
        private By purchase = By.XPath("//*[@id=\"orderModal\"]/div/div/div[3]/button[2]");
        
        internal void ClickLaptop()
        {
            driver.FindElement(nokia).Click();
        }

        internal void SelectAddCart()
        {
            driver.FindElement(addtocart).Click();
        }

        internal void SelectCart()
        {
            driver.FindElement(cart).Click();
        }

        internal void SelectPlaceOrder()
        {
            driver.FindElement(order).Click();
        }
        internal void EnterName(string samson)
        {
            driver.FindElement(name).SendKeys(samson);
        }
        internal void EnterCountry(string country)
        {
           driver.FindElement(countryy).SendKeys(country);
        }
        internal void EnterCity(string michigan)
        {
            driver.FindElement(city).SendKeys(michigan);
        }
        internal void EnterCreditCard(string card)
        {
            driver.FindElement(credit).SendKeys(card);
        }
        internal void EnterMonth(string month)
        {
            driver.FindElement(monthh).SendKeys(month);
        }

        internal void EnterYear(string year)
        {
            driver.FindElement(yearr).SendKeys(year);
        }
        internal void ClickPurchase()
        {
            driver.FindElement(purchase).Click();
        }
    }
}
