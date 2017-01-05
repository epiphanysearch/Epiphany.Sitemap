﻿namespace Epiphany.Sitemap.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Models;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;

    public class SitemapController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            return View("Sitemap", model);
        }

        #region TestData

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

        #endregion
    }
}