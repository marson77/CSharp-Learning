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
            GoToHomePage();
            Login(new AccountData("admin","secret"));
            NewMethod();
            SelectGroup(1);
            RemoveGroup();
            ReturnToGroupsPage();
        }
    }
}
