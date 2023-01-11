using Contact;
using Contacts_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contacts_Services.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetContact()
        {
            return PartialView(ContactDatabase.getContacts);
        }

        [HttpPost]
        public ActionResult PostContact(Rehber model)
        {
            if (ModelState.IsValid)
            {
                ContactDatabase.Add(model);
                return View(model);
            }
            return View(model);
        }
        [HttpPut]
        public ActionResult PutContact(Rehber model)
        {
            if (ModelState.IsValid)
            {
                ContactDatabase.editUser(model);
                return View(ContactDatabase.getContacts);
            }
            return View(model);
        }
        [HttpDelete]
        public ActionResult DeleteContact(Rehber model)
        {
            if (ModelState.IsValid)
            {
                ContactDatabase.deleteUser(model);
                return View();
            }
            return View();
        }
    }
}