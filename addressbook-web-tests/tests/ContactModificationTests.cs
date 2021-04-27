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

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.ModifyContact(newData);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = newData.Firstname;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }

        [Test]
        public void ContactModificationTest2()
        {
            ContactData newData = new ContactData("Namemodify2")
            {
                Middlename = null,
                Lastname = null
            };

            app.Contacts.ModifyContact(newData);
        }
    }
}
