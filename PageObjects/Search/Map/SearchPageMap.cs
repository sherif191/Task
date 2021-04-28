using OpenQA.Selenium;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;
using System.Collections.Generic;

namespace POMFramework.PageObjects
{
    public class SearchPageMap : BasePage
    {
        public SearchPageMap(IWebDriver driver) : base(driver)
        {
        }



        
        public IWebElement adminbutton => Helper.LocateElement(Locators.ID, "menu_admin_viewAdminModule");
        public IWebElement search_userName => Helper.LocateElement(Locators.ID, "searchSystemUser_userName");
        public IWebElement search_button => Helper.LocateElement(Locators.ID, "searchBtn");
        public IList<IWebElement> listtt =>Helper.LocateElements(Locators.ID, "//tr[@class='left']");
        public IWebElement user => Helper.LocateElement(Locators.Xpath, "//td[@class='left']/a");

        public IWebElement username => Helper.LocateElement(Locators.ID, "systemUser_userName");








    }
}