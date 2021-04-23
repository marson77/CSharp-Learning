using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
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
        }

        [Test]
        public void GroupModificationTest2()
        {
            GroupData newData = new GroupData("Testmodify2")
            {
                Header = null,
                Footer = null
            };

            app.Groups.Modify(1, newData);
        }
    }
}
