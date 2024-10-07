using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFL.Tests.BaseClass;

namespace TFL.Tests
{
    public class DropdownTest : BaseTest
    {

        [Test]
        public async Task dropDownTest()
        {
            await planAJourney.enterFromToAddress();
            await planAJourney.dropdownAction();
            await planAJourney.clickPlanMyJourney();
            var Jr = await planAJourney.journeyresults();
            // Assert that the journey results contain the expected text
            Assert.IsTrue(Jr.Contains("results"));
            System.Console.WriteLine(Jr);
            
        }


    }
}
