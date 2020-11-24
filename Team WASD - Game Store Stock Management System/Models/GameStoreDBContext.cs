using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Team_WASD___Game_Store_Stock_Management_System.Models
{
    public class GameStoreDBContext : DbContext
    {
        public GameStoreDBContext() : base("GameStoreDBContext") { }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}