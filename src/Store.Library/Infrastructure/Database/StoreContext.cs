using System;
using Store.Library.Infrastructure.Database.DataModel.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Store.Library.Infrastructure.Database
{
    public class StoreContext : DbContext
    {
        public StoreContext() {

        }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json")
                        .Build();

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 23));
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"), serverVersion);
        }
    }
}
