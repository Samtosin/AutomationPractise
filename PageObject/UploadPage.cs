using OpenQA.Selenium;
using PetStore.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.PageObject
{
    public class UploadPage
    {
        public IWebDriver driver;

        public UploadPage()
        {
            driver = WebHooks.driver;
        }

        private By choose = By.XPath("//*[@id=\"file-upload\"]");
        private By upload = By.XPath("//*[@id=\"file-submit\"]");

        public void ClickChoseFile()
        {
            driver.FindElement(choose).SendKeys("C:\\PrepMajorTest\\PetStore\\PetStore\\TestData");
        }

        public void ClickUpload()
        {
            driver.FindElement(upload).Click();
        }

        public bool UploadFilePageIsDisplayed()
        {
            return driver.Url.Contains("https://the-internet.herokuapp.com/upload");
        }
    }
}
