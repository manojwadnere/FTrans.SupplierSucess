using System.Web;
using System.Web.Optimization;

namespace UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Content/semantic-ui/semantic.js"
                        , "~/Scripts/site.js"));

            bundles.Add(new StyleBundle("~/Content/site").Include("~/Content/site.min.css"));
            bundles.Add(new StyleBundle("~/Content/semanticui").Include("~/Content/semantic-ui/semantic.min.css"));
        }
    }
}
