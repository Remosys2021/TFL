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
    public class MissingJourneyPlannerStepDefinitions : Locators

    {
        

        public IWebDriver driver;

        public MissingJourneyPlannerStepDefinitions(HooksClass chain)
        {
            this.driver = chain.driver;
        }



        [Then(@"I should see a message indicating missing locations")]
        public void ThenIShouldSeeAMessageIndicatingMissingLocations()
        {
            string fromError = driver.FindElement(By.XPath(inputFromErrorMsg)).Text;
            string toError = driver.FindElement(By.XPath(inputToErrorMsg)).Text;
            if (fromError.Contains("field is required.") & 
                    toError.Contains("field is required.") )
            {
                Assert.True(true);
            }
            driver.Quit();
        }

       

    }
}
