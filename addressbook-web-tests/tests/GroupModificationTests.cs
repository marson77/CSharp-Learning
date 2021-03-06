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

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.ModifyGroup(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void GroupModificationTest2()
        {
            GroupData newData = new GroupData("Testmodify2")
            {
                Header = null,
                Footer = null
            };

            app.Groups.ModifyGroup(0, newData);
        }
    }
}
