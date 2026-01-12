using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApp.Data
{
// To make special class for AppDbContext we have to inheret DbContext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
