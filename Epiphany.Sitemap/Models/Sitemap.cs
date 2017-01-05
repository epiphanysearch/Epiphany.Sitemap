namespace Epiphany.Sitemap.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Umbraco.Core.Models;

    public class Sitemap : IEnumerable<SitemapEntry>
    {
        public Sitemap(int nodeId)
        {
            NodeId = nodeId;
        }

        public int NodeId { get; private set; }


        public List<SitemapEntry> Entries { get; set; }

        public IEnumerator<SitemapEntry> GetEnumerator()
        {
            return Entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}