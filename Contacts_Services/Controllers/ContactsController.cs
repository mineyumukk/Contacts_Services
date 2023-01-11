using Contact;
using Contacts_Services.Models;
using System.Web.Http;

namespace Contacts_Services.Controllers
{
    public class ContactsController : ApiController
    {

        public Contacts GetRehbers()
        {
            return ContactDatabase.getContacts;
        }

        [HttpPost]
        public void Adding(Rehber model)
        {
            if (ModelState.IsValid)
            {
                ContactDatabase.Add(model);
            }

        }
        [HttpPut]
        public Contacts Editing(Rehber model)
        {
            ContactDatabase.editUser(model);
            return ContactDatabase.getContacts;
        }
        [HttpDelete]
        public void Deleting(Rehber model)
        {
            if (ModelState.IsValid)
            {
                ContactDatabase.deleteUser(model);
            }

        }
    }
}
