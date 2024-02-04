using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace expensesapp.Models
{
    public class ApplicationDbContext:DbContext
    {
    public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Category> Categories{ get; set; }

    }
}
