using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Contacts.Services
{
    public class ContactContext : DbContext
    {
        //public ContactsDB(DbContextOptions<ContactsDB> dbContext) : base(dbContext) { }

        //DBSet is used to query data and also save data to or from DB
        public DbSet<People> Peoples { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public ContactContext() : base ("ContactsCS")
        {

        }
    }
}