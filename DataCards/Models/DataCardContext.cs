using Microsoft.EntityFrameworkCore;

namespace DataCards.Models
{
    public class DataCardContext : DbContext
    {
        public DbSet<DataCard> DataCards { get; set; }
        private string DatabasePath { get; set; }

        public DataCardContext(string databasePath)
        {
            DatabasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }
}
