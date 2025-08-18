using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebStarter.Models;

namespace WebStarter.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var builder = modelBuilder.Entity<Person>();

            builder.ToTable("People");

            builder.HasAlternateKey(p => p.Id);

            builder.Property(p => p.Firstname).HasColumnName("Firstname").HasMaxLength(255).IsRequired();
            builder.Property(p => p.Lastname).HasColumnName("Lastname").HasMaxLength(255).IsRequired();
            builder.Property(p => p.Age).HasColumnName("Age").IsRequired();

        }
    }
}
