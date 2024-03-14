using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data.DbModels;
using TaskManagement.Interfaces;

namespace TaskManagement.Data
{
    public class DataContext : DbContext
    {
        //private readonly string _connectionString;
        
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        {

        }
        public virtual DbSet<ItemTask> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
