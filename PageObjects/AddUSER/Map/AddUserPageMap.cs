using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

namespace POMFramework.PageObjects
{
    internal class AddUserPageMap : BasePage
    {
        public AddUserPageMap(IWebDriver driver) : base(driver)
        {
        }

      
        public IWebElement emplyee => Helper.LocateElement(Locators.ID, "systemUser_employeeName_empName");
        public IWebElement username => Helper.LocateElement(Locators.ID, "systemUser_userName");
        public IWebElement password => Helper.LocateElement(Locators.ID, "systemUser_password");
        public IWebElement confirm_password => Helper.LocateElement(Locators.ID, "systemUser_confirmPassword");
        public IWebElement save => Helper.LocateElement(Locators.Name, "btnSave");

    }
}
