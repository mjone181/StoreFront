using System.Web.Optimization;

namespace StoreFront.UI.MVC
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

            bundles.Add(new ScriptBundle("~/Content/assets/js").Include(
                      "~/Content/assets/js/bootstrap.min.js",
                      "~/Content/assets/js/respond.min.js",
                      "~/Content/assets/js/jquery.js",
                      "~/Content/assets/js/html5shiv.js",
                      "~/Content/assets/js/modernizr.custom.js",
                      "~/Content/assets/js/classie.js",
                      "~/Content/assets/js/plugins.js",
                      "~/Content/assets/js/prettyPhoto.js",
                      "~/Content/assets/js/imagesloaded.js",
                      "~/Content/assets/js/respond.min.js",
                      "~/Content/assets/js/init.js"));

            bundles.Add(new StyleBundle("~/Content/assets/css").Include(
                      "~/Content/assets/css/bootstrap.css",
                      "~/Conent/assets/css/font-awesome.min.css",
                      "~/Content/assets/css/animate.css",
                      "~/Content/assets/css/pe-icons.css",
                      "~/Content/assets/css/prettyPhoto.css",
                      "~/Content/assets/css/style.css"));
        }
    }
}
