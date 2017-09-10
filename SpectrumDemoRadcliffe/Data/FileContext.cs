using Microsoft.EntityFrameworkCore;
using SpectrumDemoRadcliffe.Models;

namespace SpectrumDemoRadcliffe.Data
{
    public class FileContext : DbContext
    {
        public FileContext(DbContextOptions<FileContext> options) : base(options)
        {
            
        }

        public DbSet<File> Files{ get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>().ToTable("Files");
            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }



}
