// Filename: SitemapViewEngine.cs
// Author: Anthony Woodward
// Created: 21:56 05-01-2017

namespace Epiphany.Sitemap
{
    using System.Web.Mvc;

    public class SitemapViewEngine : RazorViewEngine
    {
        public SitemapViewEngine()
        {
            MasterLocationFormats = new[]
            {
                "~/bin/Views/{1}/{0}.cshtml",
                "~/bin/Views/Shared/{0}.cshtml"
            };
            ViewLocationFormats = new[]
            {
                "~/bin/Areas/{2}/Views/{1}/{0}.cshtml",
                "~/bin/Areas/{2}/Views/Shared/{0}.cshtml"
            };
        }
    }
}