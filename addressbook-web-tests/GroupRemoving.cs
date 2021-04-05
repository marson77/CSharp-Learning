using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    class GroupRemovingTests : TestBase
    { 

        [Test]
        public void GroupRemovingTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            navigator.GoToGroupPage();
            groupsHelper.SelectGroup(1);
            groupsHelper.RemoveGroup();
            groupsHelper.ReturnToGroupsPage();
            logoutHelper.LogOut();
        }
    }
}
