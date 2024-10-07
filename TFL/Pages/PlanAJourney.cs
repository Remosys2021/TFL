using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFL.Pages.PlanAJourey
{
    public class PlanAJourney
    {
        public IWebDriver driver; // WebDriver instance

        string inputFrom = "//input[@id='InputFrom']";
        string inputTo = "//input[@id='InputTo']";
        string changeTime = "//a[normalize-space()='change time']";
        string dateDD = "//select[@id='Date']";
        string timeDD = "//select[@id='Time']";
        string planjourney = "//input[@id='plan-journey-button']";
        string journeyresult = "//span[@class='jp-results-headline']";

        public PlanAJourney(IWebDriver driver)
        {
            this.driver = driver;
        }

        public async Task enterFromToAddress()
        {
            driver.FindElement(By.XPath(inputFrom)).SendKeys("Canary Wharf");
            driver.FindElement(By.XPath(inputTo)).SendKeys("Stratford");
        }

        public async Task dropdownAction()
        {

            //Click on change Time
            driver.FindElement(By.XPath(changeTime)).Click();

            // Locate the dropdown - Date Dropdown
            var dateDropdown = driver.FindElement(By.XPath(dateDD));

            // Create a SelectElement object
            var DateObj = new SelectElement(dateDropdown);

            // Select the option by visible text
            DateObj.SelectByText("Tomorrow");


            // Locate the dropdown - Time Dropdown
            var timeDropdown = driver.FindElement(By.XPath(timeDD));

            // Create a SelectElement object
            var timeObj = new SelectElement(timeDropdown);

            // Select the option by visible text
            timeObj.SelectByText("09:45");
        }

        //Click on Plan Journey btn
        public async Task clickPlanMyJourney()
        {
            driver.FindElement(By.XPath(planjourney)).Click();

        }

        //Getting text 
        public async Task<string> journeyresults() {
            string txt = driver.FindElement(By.XPath(journeyresult)).Text;
            return txt;
        }
        
    }
}
