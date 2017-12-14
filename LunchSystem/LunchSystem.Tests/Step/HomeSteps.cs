using System;
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
        
        [Given(@"I have entered ""(.*)"" into the page")]
        public void GivenIHaveEnteredIntoThePage(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I press ok")]
        public void WhenIPressOk()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should show ""(.*)"" on the screen")]
        public void ThenTheResultShouldShowOnTheScreen(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [AfterScenario("OrderMeal")]
        public void Close()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
