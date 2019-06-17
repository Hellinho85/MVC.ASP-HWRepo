using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppHW03.Models;

namespace WebAppHW03.Data
{
    // ContactDatabase where all contacts are stored and new contacts are added;
    public static class ContactsDatabase
    {
        public static List<Contact> MyContacts = new List<Contact>
        {
            new Contact()
            {
                FirstName = "Gjorgji",
                LastName = "Kongulovski",
                IsCloseFriend = true,
                PhoneNumber = 070645312
            },

            new Contact()
            {
                FirstName = "Ana",
                LastName = "Ivanovic",
                IsCloseFriend = false,
                PhoneNumber = 077550894
            },

            new Contact()
            {
                FirstName = "Risto",
                LastName = "Arsov",
                IsCloseFriend = true,
                PhoneNumber = 072145983
            },

            new Contact()
            {
                FirstName = "Kristijan",
                LastName = "Kitevski",
                IsCloseFriend = true,
                PhoneNumber = 074897365
            },

            new Contact()
            {
                FirstName = "Toshka",
                LastName = "Membranac",
                IsCloseFriend = false,
                PhoneNumber = 075789412
            },
        };
    }
}
