using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
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

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.RemoveGroup(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
