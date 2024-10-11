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
    public class InvalidJourneyPlannerStepDefinitions : Locators

    {
        

        public IWebDriver driver;

        public InvalidJourneyPlannerStepDefinitions(HooksClass chain)
        {
            this.driver = chain.driver;
        }


        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement acceptCookiesButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(invalidDestinationError)));

            bool val =driver.FindElement(By.XPath(invalidDestinationError)).Displayed;
           driver.Quit();
            Assert.IsTrue(val);
        }

    }
}
