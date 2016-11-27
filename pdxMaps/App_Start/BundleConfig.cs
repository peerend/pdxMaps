using System.Web;
using System.Web.Optimization;

namespace pdxMaps
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libraries/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/libraries/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/libraries/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/libraries/bootstrap.js",
                      "~/Scripts/libraries/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/map").Include(
                "~/Scripts/map-home.js",
                "~/Scripts/ol3/ol.js",
                "~/Scripts/ol3/ol3-layerswitcher.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/ol.css",
                      "~/Content/ol3-layerswitcher.css"));
        }
    }
}
