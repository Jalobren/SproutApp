using AutoMapper;
using Ninject.Modules;
using Sprout.DI.Resolver.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DI.Resolver.Modules
{
    public class AutomapperModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMapper>().ToMethod(AutomapperConfig.AutoMapper).InSingletonScope();
        }
    }
}
