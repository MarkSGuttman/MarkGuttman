using System.Web;
using System.Web.Optimization;

namespace MarkGuttman.CoinApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/node_modules/angular/angular.js",
                 "~/node_modules/angular-animate/angular-animate.js",
                "~/node_modules/angular-aria/angular-aria.js",
                "~/node-modules/angular-messages/angular-messages.js",
                "~/node_modules/angular-material/angular-material.js",
                 "~/node_modules/angular-route/angular-route.js",
                 "~/node_modules/angular-ui-router/release/angular-ui-router.js",
                "~/node_modules/angular-resource/angular-resource.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/d3").Include(
                "~/node_modules/d3/d3.js",
                "~/node_modules/nvd3/build/nv.d3.js",
                "~/node_modules/angular-nvd3/dist/angular-nvd3.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/node_modules/angular-material/angular-material.css",
                      "~/node_modules/nvd3/build/nv.d3.css"));
        }
    }
}
