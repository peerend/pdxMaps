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
                        "~/Scripts/libraries/jquery-{version}.js"
                        //"~/Scripts/libraries/jquery-ui.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/libraries/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/libraries/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css",
                      "~/Content/ol.css",
                      "~/Content/bootstrap-slider.css",
                      //"~/Scripts/libraries/jquery-ui.css",
                      //"~/Content/jquery-ui.min.css",
                      "~/Content/ol3-layerswitcher.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/libraries/bootstrap.js",
                      "~/Scripts/libraries/bootstrap-slider.js",
                      "~/Scripts/libraries/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/map").Include(
                "~/Scripts/map-home.js",
                "~/Scripts/ol3/ol-debug.js",
                "~/Scripts/ol3/ol3-layerswitcher.js"));
        }
    }
}
