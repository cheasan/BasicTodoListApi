using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicToDoListApi.Models.Configurations
{
    public class ListEntityTypeConfiguration : IEntityTypeConfiguration<List>
    {
        public void Configure(EntityTypeBuilder<List> builder)
        {
            builder.Property(l => l.Title).IsRequired();
            builder.Property(l => l.Status).IsRequired();
            builder.Property(l => l.CategoryId).IsRequired();
            builder.Property(l => l.IsFavorite).IsRequired();

            builder.HasMany(x => x.SubLists)
               .WithOne(b => b.List)
               .HasForeignKey(b => b.ListId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}