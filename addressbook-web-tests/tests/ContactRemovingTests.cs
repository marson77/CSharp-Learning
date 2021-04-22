using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactRemovingTests : AuthTestBase
    {

        [Test]
        public void ContactRemovingTest()
        {
            app.Contacts.Remove(1);
            app.Logout.LogOut();
        }
    }
}
