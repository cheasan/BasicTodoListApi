using BasicToDoListApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicToDoListApi.Models.Configurations
{
    public class SubListEntityTypeConfiguration : IEntityTypeConfiguration<SubList>
    {
        public void Configure(EntityTypeBuilder<SubList> builder)
        {
            builder.Property(s => s.Title).IsRequired();
            builder.Property(s => s.Status).IsRequired();
        }
    }
}