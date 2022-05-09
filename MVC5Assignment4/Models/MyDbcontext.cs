using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using System.Web.Configuration;

namespace Assignment4.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name = conn")
        {

        }
        public DbSet<Account> Accounts { get; set; }//to create table in db
    }
}