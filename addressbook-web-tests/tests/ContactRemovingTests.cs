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
            ContactData contact = new ContactData("Maks")
            {
                Middlename = "Korj",
                Lastname = "Kripovyi"
            };

            app.Contacts.RemoveContact(1, contact);
        }
    }
}
