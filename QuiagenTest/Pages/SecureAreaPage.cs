using OpenQA.Selenium;
using Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class SecureAreaPage : BasePage
    {      

        public SecureAreaPage(Driver driver) : base(driver) { }

        #region Getters
        public string GetFlashSuccessMessage()
        {
            return _driver.CreateElement(By.Id("flash")).Text;
        }
        #endregion

        public LoginPage ClickLogoutButton()
        {
            _driver.CreateElement(By.XPath("//i[contains(@class, 'signout')]")).Click();
            return new LoginPage(_driver);
        }

    }
}
