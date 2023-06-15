using NUnit.Framework;
using OpenQA.Selenium;
using PetStore.Hooks;
using PetStore.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PetStore.StepDefinitions
{
    [Binding]
    public class GreenKartSteps
    {
        public IWebDriver driver = WebHooks.driver;

        GreenKartPage greenKartPage = new GreenKartPage();

        [Given(@"that a user navigate to the website ""([^""]*)""")]
        public void GivenThatAUserNavigateToTheWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"i search for the item ""([^""]*)""")]
        public void WhenISearchForTheItem(string carrot)
        {
            Thread.Sleep(3000);
            greenKartPage.SearchItem(carrot);
        }

        [When(@"i click add to cart")]
        public void WhenIClickAddToCart()
        {
            Thread.Sleep(3000); 
            greenKartPage.ClickAdd();
        }

        [When(@"i click the basket")]
        public void WhenIClickTheBasket()
        {
            Thread.Sleep(3000); 
            greenKartPage.ClickBasket();
        }

        [When(@"i click proceed to checkout")]
        public void WhenIClickProceedToCheckout()
        {
            Thread.Sleep(3000); 
            greenKartPage.ClickCheckOut();
        }

        [When(@"i click place order")]
        public void WhenIClickPlaceOrder()
        {
            Thread.Sleep(3000); 
            greenKartPage.PlaceOrder();
        }

        [When(@"i select country ""([^""]*)""")]
        public void WhenISelectCountry(string nigeria)
        {
            Thread.Sleep(3000); 
            greenKartPage.Country(nigeria);
        }

        [When(@"i tick checkbox for terms and condition")]
        public void WhenITickCheckboxForTermsAndCondition()
        {
            Thread.Sleep(3000); 
            greenKartPage.CheckBox();
        }

        [When(@"i click proceed")]
        public void WhenIClickProceed()
        {
            Thread.Sleep(3000); 
            greenKartPage.Proceed();
        }

        [Then(@"i should be able to place order")]
        public void ThenIShouldBeAbleToPlaceOrder()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(greenKartPage.ShouldBeAbleToPlaceOrder());
        }

    }
}
