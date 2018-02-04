using System.Data.Entity;

namespace SanbanScraper
{
    public class PortfolioContext : DbContext
    {
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Symbol> Symbols { get; set; }
    }
}