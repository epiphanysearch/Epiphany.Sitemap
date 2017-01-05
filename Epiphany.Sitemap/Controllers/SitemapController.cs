namespace Epiphany.Sitemap.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Models;
    using Umbraco.Web.Models;

    public class SitemapController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            //return base.Index(model);
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