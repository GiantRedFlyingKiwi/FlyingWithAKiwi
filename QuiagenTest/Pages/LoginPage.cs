using OpenQA.Selenium;
using Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class LoginPage : BasePage
    {      

        public LoginPage(Driver driver) : base(driver) { }

        #region Getters
        public string GetPageH2Text()
        {
            return _driver.CreateElement(By.XPath("//div[@class='example']/h2")).Text;
        }

        public string GetFlashErrorMessage()
        {
            return _driver.CreateElement(By.XPath("//div[@class = 'flash error']")).Text;
        }  

        public string GetFlashSuccessMessage()
        {
            return _driver.CreateElement(By.XPath("//div[@class = 'flash success']")).Text;
        }  
        #endregion

        private void TypeUserName(string input)
        {
            _driver.CreateElement(By.Id("username")).SendKeys(input);
        }

        private void TypePassword(string input)
        {
            _driver.CreateElement(By.Id("password")).SendKeys(input);
        }

        private void ClickLoginButton() 
        {
            _driver.CreateElement(By.XPath("//button[@type='submit']/i")).Click();
        }

        public T Login<T>(string Username, string Password) where T : BasePage
        {
            TypeUserName(Username);
            TypePassword(Password);
            ClickLoginButton();
            return (T)Activator.CreateInstance(typeof(T), _driver);
        }
    }
}
