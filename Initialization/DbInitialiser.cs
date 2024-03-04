﻿using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TaskManagement.Initialization
{
    public static class DbInitialiser
    {
        public static void ApplyMigrations<T>(string connectionString) where T : DbContext
        {
            var builder = new DbContextOptionsBuilder<T>();
            builder.UseSqlServer(connectionString);
            var context = (T)Activator.CreateInstance(typeof(T), builder.Options);
            context?.Database.Migrate();
        }
    }
}
