using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data.DbModels;
using TaskManagement.Interfaces;

namespace TaskManagement.Data
{
    public class DataContext : DbContext
    {        
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        {

        }
        public virtual DbSet<ItemTask> Tasks { get; set; }
        public virtual DbSet<Bug> Bugs { get; set; }
        public virtual DbSet<Epic> Epics { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }
    }
}
