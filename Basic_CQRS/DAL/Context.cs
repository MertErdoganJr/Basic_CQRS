using Microsoft.EntityFrameworkCore;

namespace Basic_CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JNJNVEQ\\MERTSQL; initial catalog=CQRSDb; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
