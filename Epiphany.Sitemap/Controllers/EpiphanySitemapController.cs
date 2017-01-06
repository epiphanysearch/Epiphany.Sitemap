namespace Epiphany.Sitemap.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Models;
    using Umbraco.Core.Models;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;

    public class EpiphanySitemapController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var newModel = GetSitemap(model.Content);

            return CurrentTemplate(newModel);
        }

        #region TestData

        public EpiphanySitemap GetSitemap(IPublishedContent content)
        {
            return new EpiphanySitemap(content)
            {
                Entries = new List<EpiphanySitemapEntry>
                {
                    new EpiphanySitemapEntry
                    {
                        Loc = "https://www.example.com"
                    },
                    new EpiphanySitemapEntry
                    {
                        Loc = "https://www.example.com/contact"
                    }
                }
            };
        }

        #endregion
    }
}