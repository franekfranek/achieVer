using API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TaskTodo> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TaskTodo>()
                .HasOne(x => x.Creator)
                .WithMany(t => t.TasksTodo)
                .OnDelete(DeleteBehavior.Restrict); // no cascade deletion
        }

    }
}