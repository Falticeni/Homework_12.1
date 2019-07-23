using System.Web;
using System.Web.Optimization;

namespace MyMVCApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                                       "~/Content/bootstrap.css",
                                                       "~/Content/site.css"
                                                               ));

            // same as above but with IncludeDirectory() instead of include
            bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/Content/", "*.css", true));

            // Add ScriptBundle here...

            // Load scripts files from CDN
            var cdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.1.min.js";

            bundles.Add(new ScriptBundle("~/bundles/jquery", cdnPath)
                   .Include("~/Scripts/jquery-{version}.js"));
            // Create an object of ScriptBundle and
            // specify bundle name (as virtual path) as constructor parameter

            ScriptBundle scriptBndl = new ScriptBundle("~/bundles/bootstrap");

            // use Include() method to add all the script files with their paths
            scriptBndl.Include(
                                    "~/Scripts/bootstrap.js",
                                    "~/Scripts/respond.js"
                              );

            // IncludeDirectory() method of bundle class to add files under particular directory
            bundles.Add(new ScriptBundle("~/bundles/scripts").IncludeDirectory("~/Scripts/", "*.js", true));

            // Add the bundle into BundleCollection
            bundles.Add(scriptBndl);

            BundleTable.EnableOptimizations = true;


        }
    }
}
