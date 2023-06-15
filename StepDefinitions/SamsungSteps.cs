using OpenQA.Selenium;
using PetStore.Hooks;
using PetStore.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PetStore.StepDefinitions
{
    [Binding]
    public class SamsungSteps
    {
        public IWebDriver driver = WebHooks.driver;
        SamsungPage samsungPage = new SamsungPage();

        [Given(@"that i navigate to the phone website ""([^""]*)""")]
        public void GivenThatINavigateToThePhoneWebsite(string url)
        {
            Thread.Sleep(3000); 
            driver.Navigate().GoToUrl(url);
        }

        [When(@"i click nokia phone")]
        public void WhenIClickNokiaPhone()
        {
            samsungPage.ClickLaptop();
        }


        [When(@"i select add to cart")]
        public void WhenISelectAddToCart()
        {
            Thread.Sleep(3000); 
            samsungPage.SelectAddCart();
        }

        [When(@"i select cart")]
        public void WhenISelectCart()
        {
            Thread.Sleep(3000); 
            samsungPage.SelectCart();
        }

        [When(@"i select place order")]
        public void WhenISelectPlaceOrder()
        {
            Thread.Sleep(3000); 
            samsungPage.SelectPlaceOrder();
        }

        [When(@"i enter my name ""([^""]*)""")]
        public void WhenIEnterMyName(string samson)
        {
            Thread.Sleep(3000); 
            samsungPage.EnterName(samson);
        }

        [When(@"i enter country ""([^""]*)""")]
        public void WhenIEnterCountry(string country)
        {
            Thread.Sleep(3000);
            samsungPage.EnterCountry(country);
        }

        [When(@"i select city ""([^""]*)""")]
        public void WhenISelectCity(string michigan)
        {
            Thread.Sleep(3000); 
            samsungPage.EnterCity(michigan);
        }

        [When(@"i enter credit card detail ""([^""]*)""")]
        public void WhenIEnterCreditCardDetail(string card)
        {
            Thread.Sleep(3000);
            samsungPage.EnterCreditCard(card);
        }

        [When(@"i enter month ""([^""]*)""")]
        public void WhenIEnterMonth(string month)
        {
            Thread.Sleep(3000); 
            samsungPage.EnterMonth(month);
        }

        [When(@"i enter year ""([^""]*)""")]
        public void WhenIEnterYear(string year)
        {
            Thread.Sleep(3000);
            samsungPage.EnterYear(year);
        }

        [When(@"i click purchase")]
        public void WhenIClickPurchase()
        {
            Thread.Sleep(3000);
            samsungPage.ClickPurchase();
        }
    }
}
