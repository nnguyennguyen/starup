using Microsoft.EntityFrameworkCore;

namespace starup.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus{ get; set; }
    }
}
