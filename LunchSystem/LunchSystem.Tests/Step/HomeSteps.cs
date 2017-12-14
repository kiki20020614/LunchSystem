using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace LunchSystem.Tests.Step
{
    [Binding]
    public class HomeSteps
    {
        private ChromeDriver _driver = new ChromeDriver();

        [Given(@"I have opened browser to lunch system")]
        public void GivenIHaveOpenedBrowserToLunchSystem()
        {
            _driver.Navigate().GoToUrl("http://localhost:50621");
        }

        
        [Given(@"I saw the menu image")]
        public void GivenISawTheMenuImage()
        {
            //Assert.AreEqual(true, _driver.FindElement(By.XPath("//img[contains(@id,'imgMenu')]")).Displayed);




            //var imageFile = _driver.FindElement(By.XPath("//img[contains(@id,'imgMenu')]"));

            //Boolean ImagePresent = (Boolean)((JavascriptExecutor)driver).executeScript("return arguments[0].complete && typeof arguments[0].naturalWidth != \"undefined\" && arguments[0].naturalWidth > 0", ImageFile);
            //if (!ImagePresent)
            //{
            //    System.out.println("Image not displayed.");
            //}
            //else
            //{
            //    System.out.println("Image displayed.");
            //}
        }

        [Given(@"I have entered ""(.*)"" into the page")]
        public void GivenIHaveEnteredIntoThePage(string meal)
        {
            _driver.FindElement(By.Id("meal")).SendKeys(meal);
        }
        
        [When(@"I press ok")]
        public void WhenIPressOk()
        {
            _driver.FindElement(By.Id("submit")).Click();
        }

        [Then(@"the result should show ""(.*)"" on the screen")]
        public void ThenTheResultShouldShowOnTheScreen(string meal)
        {
            var _meal = _driver.FindElement(By.Id("result")).GetAttribute("innerHTML");
            Assert.AreEqual(meal, _meal);
        }

        [AfterScenario("OrderMeal")]
        public void Close()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
