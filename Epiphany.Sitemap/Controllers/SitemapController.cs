namespace Epiphany.Sitemap.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Models;

    public class SitemapController : Controller
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
        public ActionResult Index()
        {
            var sitemapEntries = GetSitemap();
            return View(sitemapEntries);
        }

        
    }
}