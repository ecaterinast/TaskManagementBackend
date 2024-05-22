using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data.DbModels;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Data.EntityConfigurations
{
    public class TaskEntityConfiguration : IEntityTypeConfiguration<ItemTask>
    {
        public void Configure(EntityTypeBuilder<ItemTask> entity)
        {
            entity.HasKey(b => b.Id);
                

        }
    }
}