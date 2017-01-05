// Filename: SitemapApplication.cs
// Author: Anthony Woodward
// Created: 22:10 05-01-2017

namespace Epiphany.Sitemap
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using Umbraco.Web;

    public class SitemapApplication : UmbracoApplication
    {
        public void Init(HttpApplication application)
        {
            application.PreRequestHandlerExecute += application_PreRequestHandlerExecute;
            application.BeginRequest += Application_BeginRequest;
            application.EndRequest += Application_EndRequest;
            application.Error += Application_Error;
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);

            ViewEngines.Engines.Add(new SitemapViewEngine());
        }

        void application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            try
            {
                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                if ((Session != null) && Session.IsNewSession)
                {
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        void Application_BeginRequest(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {
                // ignored
            }
        }

        void Application_EndRequest(object sender, EventArgs e)
        {
        }

        protected new void Application_Error(object sender, EventArgs e)
        {
        }
    }
}