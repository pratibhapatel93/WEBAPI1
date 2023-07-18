
using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;

namespace ContactsAPI.Data

{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasNoKey(); // Configure the entity with HasNoKey()
        }*/
        public DbSet<Contact> Contacts { get; set; }




    }
}