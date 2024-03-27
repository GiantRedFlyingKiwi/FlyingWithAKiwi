using NUnit.Framework;
using NUnit.Framework.Legacy;
using Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiagenTest
{
    public class LoginTests : BaseTest
    {

        //Open https://the-internet.herokuapp.com/login website
        [Test]
        [Order(1)]
        public void OpenWebsite()
        {
            //code to open the website is to be found in the BaseTest.cs in the BeforeEach()
            ClassicAssert.AreEqual("Login Page", loginPage.GetPageH2Text());
        }

        //Login using invalid credentials - Validate unsuccessfull login -- these 2 points describe the same behaviour so I personaly consider it to be covered in at leaset 2 tests, 1 with incorect username and 1 with incorect password
        //Login using invalid credentials - Validate unsuccessfull login ---->>> incorect username
        [Test]
        [Order(2)]
        public void LoginUsingInvalidUsername()
        {
            loginPage.Login<LoginPage>("tomsmith1", "SuperSecretPassword!");

            StringAssert.Contains("Your username is invalid!", loginPage.GetFlashErrorMessage());
        }


        //Login using invalid credentials - Validate unsuccessfull login ---->>> incorect password
        [Test]
        [Order(3)]
        public void LoginUsingInvalidPasswrod()
        {
            loginPage.Login<LoginPage>("tomsmith", "SuperSecretPassword");

            StringAssert.Contains("Your password is invalid!", loginPage.GetFlashErrorMessage());
        }


        //Login using invalid credentials - Validate unsuccessfull login ---->>> incorect username and password     
        //Test is set to pass if Ignore removed
        [Test]
        [Order(4)]
        [Ignore("Requirements are unclear - when loging in with both incorect username and password... its unclear which should be displayed of the 2 flash error messages 'Your username is invalid!' or 'Your password is invalid!'")]
        public void LoginUsingInvalidUsernameAndPasswrod()
        {
            loginPage.Login<LoginPage>("notGood", "NotGoodAttAll");

            StringAssert.Contains("Your username is invalid!", loginPage.GetFlashErrorMessage());
        }


        //Login using the recommended username and password
        [Test]
        [Order(5)]
        public void LoginUsingReccomentedUsernameAndPassword()
        {
            Console.WriteLine("what is a reccomented username and password?????"); 
        }

        //Validate succesfull login
        [Test]
        [Order(6)]
        public void SuccessfullLogin()
        {
            var secureAreaPage = loginPage.Login<SecureAreaPage>("tomsmith", "SuperSecretPassword!");

            StringAssert.Contains("You logged into a secure area!", secureAreaPage.GetFlashSuccessMessage());
        }

        //Logout -> Validate succesfull logOut, these 2 points describe the same behaviour so I personaly consider it to be covered in 1 test
        [Test]
        [Order(7)]
        public void SuccessfullLogout()
        {
            loginPage = loginPage.Login<SecureAreaPage>("tomsmith", "SuperSecretPassword!")
                .ClickLogoutButton();
           

            StringAssert.Contains("You logged out of the secure area!", loginPage.GetFlashSuccessMessage());
        }



    }
}
