using BasicToDoListApi.Models;
using BasicToDoListApi.Models.Configurations;
using BasicToDoListApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasicToDoListApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            new CategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<Category>());
            new ListEntityTypeConfiguration().Configure(modelBuilder.Entity<ItemList>());
            new SubListEntityTypeConfiguration().Configure(modelBuilder.Entity<SubList>());
        }
    }
}