using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using UdemyCourse.API.Models;

namespace UdemyCourse.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Value> Values { get; set; }
    }
}