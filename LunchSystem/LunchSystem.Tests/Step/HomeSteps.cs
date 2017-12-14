using System;
using TechTalk.SpecFlow;

namespace LunchSystem.Tests.Step
{
    [Binding]
    public class HomeSteps
    {
        [Given(@"I have opened browser to lunch system")]
        public void GivenIHaveOpenedBrowserToLunchSystem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered ""(.*)"" into the page")]
        public void GivenIHaveEnteredIntoThePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press ok")]
        public void WhenIPressOk()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should show ""(.*)"" on the screen")]
        public void ThenTheResultShouldShowOnTheScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
