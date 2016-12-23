namespace Epiphany.Sitemap.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SitemapControllerTests
    {
        [TestMethod]
        public void TestIndexAction()
        {
            var controller = new Controllers.SitemapController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void TestIndexAction_ReturnsXML()
        //{
        //    var controller = new Controllers.SitemapController();
        //    var result = controller.Index();

        //    Assert.IsTrue(result.View.ToString().Contains("<loc>https://www.example.com</loc>"));
        //}
    }
}
