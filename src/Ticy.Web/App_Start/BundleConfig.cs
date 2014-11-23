using System;
using System.Collections.Generic;
using System.Web.Optimization;

namespace Ticy.Web
{
    public class BundleConfig
    {
        public static string NewGuid
        {
            get
            {
                return Guid.NewGuid().ToString().Split('-')[0];
            }
        }

        public static Dictionary<string, string> ObfuscateMap = new Dictionary<string, string>
        {
            {"~/jquery", "~/\{NewGuid}" },
            {"~/jqueryval", "~/\{NewGuid}"},
            {"~/modernizr", "~/\{NewGuid}" },
            {"~/bootstrap", "~/\{NewGuid}" },
            {"~/prism", "~/\{NewGuid}" },
            {"~/css", "~/\{NewGuid}" },
            {"~/prism-css", "~/\{NewGuid}" },
            {"~/disqus", "~/\{NewGuid}" }
        };

        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(ObfuscateMap["~/jquery"]).Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle(ObfuscateMap["~/jqueryval"]).Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle(ObfuscateMap["~/modernizr"]).Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle(ObfuscateMap["~/bootstrap"]).Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle(ObfuscateMap["~/prism"]).Include(
                        "~/Content/prism/prism.js"));

            bundles.Add(new ScriptBundle(ObfuscateMap["~/disqus"]).Include(
                        "~/Content/disqus/disqus.js"));

            #region styles
            bundles.Add(new StyleBundle(ObfuscateMap["~/css"]).Include(
                       "~/Content/bootstrap.css",
                       "~/Content/site.css"));

            bundles.Add(new StyleBundle(ObfuscateMap["~/prism-css"]).Include(
                        "~/Content/prism/prism.css"));
            #endregion

            BundleTable.EnableOptimizations = true;
        }
    }
}
