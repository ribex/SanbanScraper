using System.Collections.Generic;

namespace SanbanScraper
{
    public class Portfolio
    {
        // primary key
        public int PortfolioId { get; set; }
        public string Name { get; set; }

        // navigation property
        public virtual List<Symbol> Symbols { get; set; }
    }
}