using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            optionsBuilder
                .UseSqlServer(@"Server=127.0.0.1,1433;Database=CursoMVC;User Id=SA;Password=mssql1Ipw");
        }
    }
}
