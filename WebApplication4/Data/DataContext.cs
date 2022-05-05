using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<City>  Cities { get; set; }
        public DbSet<Photo>  Photos { get; set; }
        public DbSet<User>  Users { get; set; }
   
    }
}
