using OpenQA.Selenium;
using Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class BasePage
    {
        public Driver _driver {  get; set; }

        public BasePage(Driver driver) {
            _driver = driver;
        }


    }
}
