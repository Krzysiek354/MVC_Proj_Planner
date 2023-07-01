using Microsoft.EntityFrameworkCore;
using Projekt_MVC.Models;


namespace Projekt_MVC.Models
{
    public class DB_Context:DbContext
    {

        public DbSet<School> Schools { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Enjoy> Enjoys { get; set; }

        public DbSet<Message> Messages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MVC_Proj;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Projekt_MVC.Models.Enjoy>? Enjoy { get; set; }

    }
}
