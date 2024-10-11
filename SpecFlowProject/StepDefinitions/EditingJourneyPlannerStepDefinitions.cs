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
    public class EditingJourneyPlannerStepDefinitions : Locators

    {
        

        public IWebDriver driver;

        public EditingJourneyPlannerStepDefinitions(HooksClass chain)
        {
            this.driver = chain.driver;
        }


       

        [When(@"I edit the journey details")]
        public void WhenIEditTheJourneyDetails()
        {
            driver.FindElement(By.XPath(editJourney)).Click();
        }

        [Then(@"I should be able to amend the journey")]
        public void ThenIShouldBeAbleToAmendTheJourney()
        {
            bool re =
                driver.FindElement(By.XPath(planjourney)).Displayed;
            driver.Quit();
            Assert.IsTrue(re);
        }

       
    }
}
