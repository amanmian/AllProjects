using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace adminlte.App_Start
{
    public class Bundleconfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                      "~/Scripts/jquery-1.10.2.js",
                      "~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/script.js"));
            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
             "~/admin-lte/js/app.js", "~/admin-lte/plugins/fastclick/fastclick.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/site.css",
                       "~/admin-lte/css/AdminLTE.css",
                       "~/admin-lte/css/skins/skin-blue.css"
                       ));
        }
    }
}
}