using NUnit.Framework;
using POMFramework.PageObjects;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class adduser : BaseTest
    {

        [Test]
        [Description("add_user_checking_value Test")]

        public void add_user_checking_value()
        {
            string employee_name = "Aaliyah Haq";
            string user_name = "zamalek2020";
            string password = "12345678910";

            //   Pages.Home.GoTo();
            Pages.Home.GoTo();

            Pages.Home.Gotoadduser();
            Pages.adduser.addnewuser(employee_name, user_name,password);
         //   Pages.searchuser.Sleep(3000);
            //search
            Pages.searchuser.search(user_name);
           

            string Actual_employee = Pages.adduser.getemployeename();
            string Actual_username = Pages.adduser.geteusername();


            Assert.AreEqual(Actual_employee, employee_name);
            Assert.AreEqual(Actual_username, user_name);

            
        }


    }
}
