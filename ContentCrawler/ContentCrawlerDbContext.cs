using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentCrawler
{
    class ContentCrawlerDbContext : DbContext
    {
        public ContentCrawlerDbContext() : base("ConnectionStringContentCrawler")
        {
                
        }

        public DbSet<Post> Posts { get; set; }
    }
}
