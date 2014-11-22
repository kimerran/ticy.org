using System.Web;
using System.Web.Optimization;

namespace Ticy.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/prism").Include(
                "~/Content/prism/prism.js"));

            bundles.Add(new ScriptBundle("~/disqus").Include(
                "~/Content/disqus/disqus.js"));


            #region styles
            bundles.Add(new StyleBundle("~/css").Include(
               "~/Content/bootstrap.css",
               "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/prism-css").Include(
                "~/Content/prism/prism.css"));
            #endregion


            BundleTable.EnableOptimizations = true;


        }
    }
}
