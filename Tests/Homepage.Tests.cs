using NUnit.Framework;
using POMFramework.PageObjects;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class Homepage : BaseTest
    {

        [Test]
        [Description("Login Test")]

        public void Valid_Login()
        {
            //   Pages.Home.GoTo();
            Pages.Home.GoTo();
            Pages.Home.Login();
            Assert.IsTrue(Pages.Home.Map.adminbutton.Displayed);


        }


    }
}
