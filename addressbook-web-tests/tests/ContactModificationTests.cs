using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Namemodify1")
            {
                Middlename = "Namemodify2",
                Lastname = "Namemodify3"
            };

            app.Contacts.Modify(newData);
        }

        [Test]
        public void ContactModificationTest2()
        {
            ContactData newData = new ContactData("Namemodify2")
            {
                Middlename = null,
                Lastname = null
            };

            app.Contacts.Modify(newData);
        }
    }
}
