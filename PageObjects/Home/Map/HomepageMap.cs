using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;

namespace POMFramework.PageObjects
{
    // This class stores the locators to all of the elements that can be interacted with on the page


    public class HomePageMap : BasePage
    {
        public HomePageMap(IWebDriver driver) : base(driver)
        {
        }

        //Page elements used for synchronisation
        public By InventoryContainer => By.Id("inventory_container");

        //Page elements for interaction
        public IWebElement UsernameField => Helper.LocateElement(Locators.ID, "txtUsername");
        public IWebElement PasswordField => Helper.LocateElement(Locators.ID, "txtPassword");
        public IWebElement LoginButton => Helper.LocateElement(Locators.Name, "Submit");
        public IWebElement adminbutton => Helper.LocateElement(Locators.ID, "menu_admin_viewAdminModule");
        public IWebElement addbutton => Helper.LocateElement(Locators.ID, "btnAdd");





    }
}
