using Microsoft.EntityFrameworkCore;
using Sms.Models;

namespace Sms.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}