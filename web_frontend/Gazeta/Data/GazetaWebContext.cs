using Gazeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data
{
    public class GazetaWebContext:DbContext
    {
        public GazetaWebContext(DbContextOptions<GazetaWebContext> options) : base(options)
        {

        }

        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(x => x.Email);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().HasKey(x => x.CompanyName);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Subscription>().HasKey(x => x.SubscriptionId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
