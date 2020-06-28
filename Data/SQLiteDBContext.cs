using server.Models;
using Microsoft.EntityFrameworkCore;

namespace server
{
    public class SQLiteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=sq.db");
    }
}