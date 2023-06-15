using NUnit.Framework;
using OpenQA.Selenium;
using PetStore.Hooks;
using PetStore.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PetStore.StepDefinitions
{
    [Binding]
    public class FIleUploadSteps
    {
        public IWebDriver driver = WebHooks.driver;

       UploadPage uploadPage = new UploadPage();

        [Given(@"that i navigate to the website ""([^""]*)""")]
        public void GivenThatINavigateToTheWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"i click chose file")]
        public void WhenIClickChoseFile()
        {
            Thread.Sleep(3000);
            uploadPage.ClickChoseFile();
        }

        [When(@"i click upload")]
        public void WhenIClickUpload()
        {
            Thread.Sleep(3000); 
            uploadPage.ClickUpload();
        }


        [Then(@"i should be able to upload file")]
        public void ThenIShouldBeAbleToUploadFile()
        {
            Thread.Sleep(3000); 
            Assert.IsTrue(uploadPage.UploadFilePageIsDisplayed());
        }
    }
}
