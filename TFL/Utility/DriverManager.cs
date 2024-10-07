using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading.Tasks;

namespace TFL.Utility.Webdriver
{
    public class DriverManager
    {
        private IWebDriver driver; // WebDriver instance

        // Method to return WebDriver, defaulting to Chrome if no browser is specified
        public async Task<IWebDriver> getDriver(string browserName = "chrome")
        {
            if (driver == null)
            {
              
                
                // Handle different browsers based on the argument
                if (browserName=="chrome")
                {
                    driver = new ChromeDriver();
                }
                else if (browserName=="firefox")
                {
                    driver = new FirefoxDriver();
                }
                else if (browserName=="edge")
                {
                    driver = new EdgeDriver();
                }
                else
                {
                    // Default to Chrome if the browser is not recognized
                    Console.WriteLine($"Browser '{browserName}' not recognized. Defaulting to Chrome.");
                    driver = new ChromeDriver();
                }

                // Maximize the browser window
                     driver.Manage().Window.Maximize();
            }

            return driver; // Return the initialized WebDriver instance
        }

        // Method to quit the WebDriver
        public async Task quitDriver()
        {
            if (driver != null)
            {
               driver.Quit(); // Quit the WebDriver
                driver = null; // Reset the driver to null
            }
        }
    }
}
