using Microsoft.EntityFrameworkCore;
namespace expensesapp.Models
{
    public class ApplicationDbContext:DbContext
    {
    public ApplicationDbContext(DbContextOptions options):base(options)
        {}
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Especificar el tipo de columna para la propiedad Amount en la entidad Transaction
            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .HasColumnType("decimal(18, 2)");

            // Otras configuraciones de modelo si las tienes...

            base.OnModelCreating(modelBuilder);
        }
    }
}
