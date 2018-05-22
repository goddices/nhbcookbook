using System; 
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NHibernate;
using NHibernate.Cfg;

namespace NHibernateCookbook.WebSite
{
    public class MvcApplication : HttpApplication
    { 
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigNHibnerte();
        }
        private static void ConfigNHibnerte()
        {
            var nhConfig = new Configuration().Configure();
            SessionFactory = nhConfig.BuildSessionFactory();
        }
        public static ISessionFactory SessionFactory
        {
            get;
            private set;
        }

 
    }
}
