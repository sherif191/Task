using NUnit.Framework;
using OpenQA.Selenium;
using POMFramework.PageObjects;
using POMFramework.Driver;
using System;

namespace POMFramework
{
    public class BaseTest
    {
        private IWebDriver Driver { get; set; }

        [SetUp]
        public void TestSetup()
        {
            var factory = new Factory();
            Driver = factory.CreateBrowser(Network.Local, BrowserType.Chrome);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

            Pages.Init(Driver);
        }

        [TearDown]
        public void TestEnding()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
