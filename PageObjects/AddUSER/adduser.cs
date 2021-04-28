using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    internal class adduser : BasePage
    {
        public readonly AddUserPageMap Map;
        public adduser(IWebDriver driver) : base(driver)
        {
            // Creates a new mapping file when the page object is created

            Map = new AddUserPageMap(driver);
        }

        public void Sleep(int milll)
        {
            System.Threading.Thread.Sleep(milll);
        }

        public void addnewuser(string employeename, string username, string password)
        {
            Map.emplyee.SendKeys(employeename);
            Map.username.SendKeys(username);
            Map.password.SendKeys(password);
            Map.confirm_password.SendKeys(password);
            Sleep(10);
            Map.save.Click();
     //       Map.save.Click();
        //    Map.save.Click();




        }
        public string getemployeename() {

            string employee = Map.emplyee.GetAttribute("value");
            return employee;

        }
        public string geteusername()
        {

            string usernamee = Map.username.GetAttribute("value");
            return usernamee;

        }




    }
}
