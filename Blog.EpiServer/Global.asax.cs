using Blog.EpiServer.Configs;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Blog.EpiServer
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AreaRegistration.RegisterAllAreas();

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }
    }
}