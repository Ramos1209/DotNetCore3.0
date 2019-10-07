using ApiNetCore_Data.Mapping;
using ApiNetCore_Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ApiNetCore_Data.Context
{
   public class DotNetContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = DESKTOP-6JE120I\\SQLEXPRESS01; Initial Catalog = DotNetApi; Integrated Security = True";

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}
