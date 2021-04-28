using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMFramework.PageObjects.Base;
using POMFramework.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace POMFramework.PageObjects
{
    // This object stores all the methods available to the page object

    public class searchuser : BasePage
    {


        public readonly SearchPageMap Map;

        public searchuser(IWebDriver driver) : base(driver)
        {
            Map = new SearchPageMap(driver);

        }
         
                // Extra.Sleep(2000) - will wait for 2 seconds
                public  void Sleep (int milll)
        {
            System.Threading.Thread.Sleep(milll);
        }
    

    public void search(string username)
        {
           // Map.adminbutton.Click();
            Map.search_userName.SendKeys(username);
            Map.search_button.Click();
            Map.user.Click();
            //*[@id="resultTable"]/tbody/tr/td[2]/a
            //  IList<IWebElement> listtt = Helper.LocateElements(Locators.ID, "//tr[@class='left']");


            //  foreach (IWebElement element in listtt)
            {
                //      if (element.GetAttribute("innerHTML") == username)
                //      {
                //       element.Click();
                //
                //    }

            }

}

    }
}
