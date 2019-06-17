using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppHW03.Models;
using WebAppHW03.Data;

namespace WebAppHW03.Controllers
{
    // CoolController with it's route and required actions with View;
    [Route("Contacts")]
    public class CoolController : Controller
    {
        // GetEveryone action method with it's route and View;
        [Route("get-all-contacts")]
        public IActionResult GetEveryone()
        {
            var AllContacts = new ListOfContacts
            {
                MyContacts = ContactsDatabase.MyContacts
            };

            return View(AllContacts);
        }

        // GetFriends action method with it's route and View;
        [Route("get-closest-contacts")]
        public IActionResult GetFriends()
        {
            var CloseContacts = new ListOfContacts
            {
                MyContacts = ContactsDatabase.MyContacts
            };

            return View(CloseContacts);
        }

        // AddContact action method with Get method and View;
        [HttpGet]
        public IActionResult AddContact()
        {
            return View(new Contact());
        }

        // AddContact action method with Post method and View;
        [HttpPost]
        public IActionResult AddContact(Contact MyContact)
        {
            ContactsDatabase.MyContacts.Add(MyContact);
            return View(new Contact());
        }        
    }
}