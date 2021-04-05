using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            InitGroupCreation();
            GroupData group = new GroupData("Test1");
            group.Header = "Test2";
            group.Footer = "Test3";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            LogOut();
        }
    }
}
