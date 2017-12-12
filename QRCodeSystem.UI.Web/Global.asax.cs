using System;
using System.Web.Optimization;

namespace QRCodeSystem.UI.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            BundleTable.Bundles.Add(new StyleBundle("~/content/adminlte").IncludeDirectory("~/admin-lte/css", "*.min.css"));

            BundleTable.Bundles.Add(new StyleBundle("~/content/css").IncludeDirectory("~/content", "*.min.css"));

            BundleTable.Bundles.Add(new ScriptBundle("~/scripts/adminlte").Include(
                "~/Scripts/jquery-3.1.1.min.js","~/admin-lte/js/adminlte.min.js"
                ));

            BundleTable.EnableOptimizations = true;
        }
    }
}