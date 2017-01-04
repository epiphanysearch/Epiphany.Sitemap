namespace Epiphany.Sitemap.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Models;
    using Umbraco.Web.Mvc;

    public abstract class SitemapController : RenderMvcController
    {

        [NonAction]
        public Sitemap GetSitemap()
        {
            return new Sitemap(1)
            {
                Entries = new List<SitemapEntry>
                {
                    new SitemapEntry
                    {
                        Loc = "https://www.example.com"
                    },

                    new SitemapEntry
                    {
                       Loc = "https://www.example.com/contact"
                    }
                }
            };
        }

        // GET: Sitemap
        public ViewResult Index()
        {
            var sitemapEntries = GetSitemap();
            return View("Index", sitemapEntries);
        }

        
    }
}