﻿using System.Web;
using System.Web.Optimization;

namespace MarkGuttman.NAT
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/angular").Include(
            //          "~/Scripts/angular.js",
            //          "~/Scripts/angular-animate/angular-animate.js",
            //          "~/Scripts/angular-route.js", 
            //          "~/Scripts/angular-aria/angular-aria.js",
            //          "~/Scripts/angular-messages.js",
            //        //   "~/Scripts/angular-material/angular-material.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new ScriptBundle("~/bundles/angular-material").Include(
            //    "~/Scripts/angular-material/angular-material.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/angular-material.css",
                      "~/Content/angular-material.layouts.css",
                      "~/Content/site.css"));
        }
    }
}
