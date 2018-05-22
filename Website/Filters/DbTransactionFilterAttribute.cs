using System;
using System.Web.Mvc;
using NHibernate.Context;

namespace NHibernateCookbook.WebSite.Filters
{
    public class DbTransactionFilterAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            var session = MvcApplication.SessionFactory.OpenSession();
            CurrentSessionContext.Bind(session);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            var session = CurrentSessionContext.Unbind(MvcApplication.SessionFactory);
            session.Dispose();
        }
    }
}