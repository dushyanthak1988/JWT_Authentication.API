using JWT_Authentication.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWT_Authentication.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public DataContext(DbContextOptions options) : base(options) { }


    }
}
