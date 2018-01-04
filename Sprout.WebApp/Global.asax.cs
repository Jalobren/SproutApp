using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sprout.WebApp
{
    //public class MvcApplication : System.Web.HttpApplication
    //{
    //    protected void Application_Start()
    //    {
    //        AreaRegistration.RegisterAllAreas();
    //        RouteConfig.RegisterRoutes(RouteTable.Routes);
    //    }
    //}

    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
    {
        AreaRegistration.RegisterAllAreas();
        RouteConfig.RegisterRoutes(RouteTable.Routes);
    }


    protected override IKernel CreateKernel()
    {
        var kernel = new StandardKernel();
        kernel.Load(Assembly.GetExecutingAssembly());
        return kernel;
    }
}
}
