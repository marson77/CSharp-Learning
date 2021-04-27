using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovingTests : AuthTestBase
    { 

        [Test]
        public void GroupRemovingTest()
        {
            GroupData newData = new GroupData("Testmodify1")
            {
                Header = "Testmodify2",
                Footer = "Testmodify3"
            };

            app.Groups.RemoveGroup(1, newData);
        }
    }
}
