using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_for_London.Support
{
    public class Locators
    {

        //ul[@class='field-validation-errors']/li
        public string acceptAllcookies = "//strong[normalize-space()='Accept all cookies']";
        public string inputFrom = "//input[@id='InputFrom']";
        public string inputTo = "//input[@id='InputTo']";
        public string changeTime = "//a[normalize-space()='change time']";
        public string dateDD = "//select[@id='Date']";
        public string timeDD = "//select[@id='Time']";
        public string planjourney = "//input[@id='plan-journey-button']";
        public string suggestionList = "//strong/preceding::span[@class='stop-name']";
       public  string journeyresult = "//span[@class='jp-results-headline']";
        public string inputFromErrorMsg = "//span[@id='InputFrom-error']";
        public string inputToErrorMsg = "//span[@data-valmsg-for='InputTo']";
        public string invalidDestinationError = "//li[@class='field-validation-error']";
        public string recentsTab = "//a[normalize-space()='Recents']";
        public string editJourney = "//span[normalize-space()='Edit journey']";

    }
}
