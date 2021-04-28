using NUnit.Framework;
using POMFramework.PageObjects;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class usersearch : BaseTest
    {


        [Test]
        [Description("search Test")]
        public void search()
        {
            string user_search = "admin";
            Pages.Home.GoTo();
            Pages.Home.Login();
            Pages.searchuser.search(user_search);

            //Pages.Inventory.LogOut();

             Assert.IsTrue(Pages.searchuser.Map.username.Displayed);

        }

    }
}
