using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Models;
using System.Data.Entity;

namespace Project.DataBase
{
    public class UserDataBase : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().ToTable("Project");
        }

        public DbSet<Account> Users { get; set; }
    }
}