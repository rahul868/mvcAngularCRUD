﻿using System.Web;
using System.Web.Optimization;

namespace AngularJSDemo4
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-dateFormat.min.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/angular.js",
                       "~/Scripts/angular-animate.min.js",
                       "~/Scripts/ui-bootstrap-tpls-0.14.2.js"));
            bundles.Add(new ScriptBundle("~/bundles/StudentJs").Include(
                                 "~/Scripts/StudentScript/Module.js",
                                 "~/Scripts/StudentScript/Service.js",
                                 "~/Scripts/StudentScript/Controller.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}