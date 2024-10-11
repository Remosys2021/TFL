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
    public class ValidJourneyPlannerStep : Locators

    {
        

        public IWebDriver driver;

        public ValidJourneyPlannerStep(HooksClass chain)
        {
            this.driver = chain.driver;
        }


        [Given(@"I have navigated to the TFL journey planner")]
        public void GivenIHaveNavigatedToTheTFLJourneyPlanner()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tfl.gov.uk/plan-a-journey/");
            //driver.FindElement(By.XPath("//strong[normalize-space()='Accept all cookies']")).Click();

            // Create a wait object with a timeout
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait until the "Accept all cookies" button is clickable
            IWebElement acceptCookiesButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(acceptAllcookies)));

            // Click the button
            acceptCookiesButton.Click();


        }

        [When(@"I enter '([^']*)' in the From field")]
        public void WhenIEnterInTheFromField(string heathrow)
        {
            driver.FindElement(By.XPath(inputFrom))
                .SendKeys(heathrow);
            

        }

        [When(@"I enter '([^']*)' in the To field")]
        public void WhenIEnterInTheToField(string paddington)
        {
            driver.FindElement(By.XPath(inputTo))
                 .SendKeys(paddington);
            
            
        }

        [When(@"I click the Plan My Journey button")]
        public void WhenIClickThePlanMyJourneyButton()
        {
            try
            {
                driver.FindElement(By.XPath(planjourney)).Click();
            }
            catch {
                var element = driver.FindElement(By.XPath(planjourney));
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript("arguments[0].click();", element);
            }
        }

        [Then(@"I should see the journey results")]
        public void ThenIShouldSeeTheJourneyResults()
        {
            string txt = driver.FindElement(By.XPath(journeyresult)).Text;
            //Thread.Sleep(5000);
            driver.Quit();
            Assert.IsTrue(txt.Contains("results"));


        }



    }
}
