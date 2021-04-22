using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactAddingTests : AuthTestBase
    {
        [Test]
        public void ContactAddingTest()
        {
            ContactData contact = new ContactData("Maks")
            {
                Middlename = "Korj",
                Lastname = "Kripovyi"
            };

            app.Contacts.Create(contact);
            app.Logout.LogOut();
        }

        [Test]
        public void EmptyNameContactAddingTest()
        {
            ContactData contact = new ContactData("")
            {
                Middlename = "",
                Lastname = ""
            };

            app.Contacts.Create(contact);
            app.Logout.LogOut();
        }
    }
}
