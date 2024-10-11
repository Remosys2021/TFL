using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using Transport_for_London.Support;
using SpecFlowProject.Hooks;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class RecentsJourneyPlannerStepDefinitions : Locators

    {
        

        public IWebDriver driver;

        public RecentsJourneyPlannerStepDefinitions(HooksClass chain)
        {
            this.driver = chain.driver;
        }


        [When(@"navigated to the TFL journey planner")]
        public void WhenNavigatedToTheTFLJourneyPlanner()
        {
            
            driver.Navigate().Back();
        }


        [When(@"I click the recents tab")]
        public void WhenIClickTheRecentsTab()
        {
            driver.FindElement(By.XPath(recentsTab)).Click();
        }

        [Then(@"I should see the list of recent journeys")]
        public void ThenIShouldSeeTheListOfRecentJourneys()
        {
            Thread.Sleep(7000);
            driver.Quit();
          
        }

    }
}
