using NUnit.Framework;
using Pages;
using Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiagenTest
{
    public class BaseTest
    {
        public LoginPage loginPage;
        public Driver _driver { get; set; }
        readonly DriverFactory factory = new DriverFactory();

        [SetUp]
        public void BeforeEach() 
        {
            _driver = factory.CreateDriver();
            _driver.GoToUrl("https://the-internet.herokuapp.com/login");            
            loginPage = new LoginPage(_driver);
        }

        [TearDown]
        public void AfterEach()
        {
            _driver.Close();
        }
    }
}
