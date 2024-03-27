using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourses
{
    public class Driver
    {
        private readonly IWebDriver _driver;

        public Driver(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);    
        }

        public void Close()
        {
            _driver.Close(); 
        }

        public IWebElement CreateElement(By locator)
        {
            return  _driver.FindElement(locator);
        }
    }
}
