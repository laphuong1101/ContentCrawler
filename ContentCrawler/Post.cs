using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentCrawler
{
    class Post
    {
        public int Id { get; set; }
        public string UrlBasePost { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UrlImg { get; set; }
        public string Content { get; set; }
    }
}
