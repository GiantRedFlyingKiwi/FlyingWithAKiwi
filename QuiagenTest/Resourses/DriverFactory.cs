using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourses
{
    public class DriverFactory
    {
        public ChromeDriver chromedriver;

        public Driver CreateDriver()
        {
            var browserOptions = new ChromeOptions();
            browserOptions.AddArguments("start-maximized");
            chromedriver = new ChromeDriver(browserOptions);
            return new Driver(chromedriver);
        }
    }
}
