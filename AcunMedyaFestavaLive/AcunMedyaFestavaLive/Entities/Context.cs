using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AcunMedyaFestavaLive.Entities
{
    public class Context:DbContext
    {
        public DbSet<Artist> artists { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<UserBuy> userBuys { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<User> users { get; set; } 


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}