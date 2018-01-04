using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.WebHost;
using Sprout.DI.Resolver.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Sprout.WebApi
{
    public class WebApiApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected override IKernel CreateKernel()
        {
            INinjectModule[] modules = 
            {
                new BLModule(),
                new DLModule(),
                new AutomapperModule()
            };
            var kernel = new StandardKernel(modules);
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }
    }
}
