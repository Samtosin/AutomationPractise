using OpenQA.Selenium;
using PetStore.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.PageObject
{
    public class GreenKartPage
    {
        public IWebDriver driver;
        public GreenKartPage()
        {
            driver = WebHooks.driver;
        }

        private By search = By.XPath("//*[@id=\"root\"]/div/header/div/div[2]/form/input");
        private By addcart = By.XPath("//*[@id=\"root\"]/div/div[1]/div/div/div[3]/button");
        private By basket = By.XPath("//*[@id=\"root\"]/div/header/div/div[3]/a[4]/img");
        private By checkout = By.XPath("//*[@id=\"root\"]/div/header/div/div[3]/div[2]/div[2]/button");
        private By order = By.XPath("//*[@id=\"root\"]/div/div/div/div/button");
        private By country = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/select");
        private By tickbox = By.XPath("//*[@id=\"root\"]/div/div/div/div/input");
        private By clickproceed = By.XPath("//*[@id=\"root\"]/div/div/div/div/button");
        

        public void SearchItem(string carrot)
        {
            driver.FindElement(search).SendKeys(carrot);
        }
        public void ClickAdd()
        {
            driver.FindElement(addcart).Click();
        }

        public void ClickBasket()
        {
            driver.FindElement(basket).Click();
        }

        public void ClickCheckOut()
        {
            driver.FindElement(checkout).Click();
        }

        internal void PlaceOrder()
        {
            driver.FindElement(order).Click();
        }

        internal void Country(string Nigeria)
        {
            driver.FindElement(country).SendKeys(Nigeria);
        }

        internal void CheckBox()
        {
            driver.FindElement(tickbox).Click();
        }

        internal void Proceed()
        {
            driver.FindElement(clickproceed).Click();
        }

        internal bool? ShouldBeAbleToPlaceOrder()
        {
            return driver.Url.Contains("https://rahulshettyacademy.com/seleniumPractise/#/country");
        }
    }


}
