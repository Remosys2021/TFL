using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading.Tasks;
using TFL.Utility.Webdriver;
using TFL.Pages.PlanAJourey;

namespace TFL.Tests.BaseClass
{
    public class BaseTest : DriverManager
    {
        public PlanAJourney planAJourney;
        protected IWebDriver Driver; // WebDriver instance
        


        [OneTimeSetUp]
        public async Task SuiteSetup()
        {
           
            // get the WebDriver instance
            Driver = await getDriver("chrome") ; // Specify the browser if needed
        }

        [SetUp]
        public async Task SetUp()
        {
            planAJourney = new PlanAJourney(Driver);
            // Example usage of Driver, navigating to a URL
            await Task.Run(() => Driver.Navigate().GoToUrl("https://tfl.gov.uk")); // Replace with your application URL


            Driver.FindElement(By.XPath("//strong[normalize-space()='Accept all cookies']")).Click();
            //Driver.FindElement(By.XPath("//strong[normalize-space()='Accept only essential cookies']")).Click();
            

        }

        [TearDown]
        public void TearDown()
        {
            // Optional: Add per-test clean-up logic if needed
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Quit the WebDriver after all tests are done
            quitDriver();
        }
    }
}
