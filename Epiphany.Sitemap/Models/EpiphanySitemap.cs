namespace Epiphany.Sitemap.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Umbraco.Core.Models;
    using Umbraco.Web.Models;

    public class EpiphanySitemap : RenderModel, IEnumerable<EpiphanySitemapEntry>
    {

        public EpiphanySitemap(IPublishedContent content) : base(content)
        {
        }

        public int NodeId { get; private set; }


        public List<EpiphanySitemapEntry> Entries { get; set; }

        public IEnumerator<EpiphanySitemapEntry> GetEnumerator()
        {
            return Entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}