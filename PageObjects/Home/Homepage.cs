using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using System;

namespace POMFramework.PageObjects
{
    // This class stores all of the methods available to the page class

    public class HomePage : BasePage
    {
        public readonly HomePageMap Map;
        public HomePage(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new HomePageMap(driver);
        }

        // Test methods available that are available to the test cases.

        public void GoTo()
        {
            Helper.GoToUrl("https://opensource-demo.orangehrmlive.com");
        }

        public void Login()
        {


            Map.UsernameField.SendKeys("Admin");


            Map.PasswordField.SendKeys("admin123");
            //    Map.PasswordField.SendKeys(Keys.Enter);


            Map.LoginButton.Click();
            Map.adminbutton.Click();


            //   Helper.WaitForPageToLoad(Map.InventoryContainer);
        }



        public void Gotoadduser()
        {

            Login();
            Map.adminbutton.Click();
            Map.addbutton.Click();
       //     Map.addbutton.Click();


        }

    }
}