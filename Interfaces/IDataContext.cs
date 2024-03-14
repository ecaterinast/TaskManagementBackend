using Microsoft.EntityFrameworkCore;
using TaskManagement.Data.DbModels;

namespace TaskManagement.Interfaces
{
    public interface IDataContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ItemTask> Tasks { get; set; }

        public void SaveChanges();
    }
}
