using Ninject.Modules;
using Sprout.WebApp.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sprout.WebApp.App_Start
{
    public class DependencyModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWebClient>().To<WebClient>();
        }
    }
}