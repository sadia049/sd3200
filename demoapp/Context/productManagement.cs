using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using demoapp.Models;
namespace demoapp.Context
{
    public class productManagement:DbContext
    {
        public productManagement() : base("productManagementDB") { }

        public DbSet<Category> categories { get; set; }
        public DbSet<product> products { get; set; }
    }
}