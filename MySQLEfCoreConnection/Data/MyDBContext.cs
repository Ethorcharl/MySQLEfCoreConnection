using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MySQLEfCoreConnection.Data
{
    public class MyDBContext : DbContext
    {
        //ctor create new constructor
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) 
        {
            
        }
        public DbSet<Person> Person { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>(e => e.Property(o => o.Age).HasColumnType("tinyint").HasConversion<short>());
            modelBuilder.Entity<Person>(e => e.Property(o=>o.IsPlayer).HasConversion(new BoolToZeroOneConverter<Int16>()).HasColumnType("bit"));
        }
    }
}
