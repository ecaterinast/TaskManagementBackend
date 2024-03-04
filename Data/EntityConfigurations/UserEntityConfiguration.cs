using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data.DbModels;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Emit;

namespace TaskManagement.Data.EntityConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(b => b.Id);
            entity.Property(b => b.Name).HasMaxLength(20);

        }
    }
}
