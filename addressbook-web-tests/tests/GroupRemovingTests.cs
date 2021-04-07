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
            app.Groups.Remove(1);
            app.Logout.LogOut();
        }
    }
}
