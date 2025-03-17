using Microsoft.EntityFrameworkCore;
using MVCapplication.Models;

namespace MVCapplication.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
