using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Testmodify1")
            {
                Header = "Testmodify2",
                Footer = "Testmodify3"
            };

            app.Groups.Modify(1, newData);
            app.Logout.LogOut();
        }
    }
}
