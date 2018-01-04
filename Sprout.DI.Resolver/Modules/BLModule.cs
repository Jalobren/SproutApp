using Ninject.Modules;
using Sprout.BL;
using Sprout.BL.Interfaces;
using Sprout.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DI.Resolver.Modules
{
    public class BLModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEmployeeBL>().To<EmployeeBL>();
        }
    }
}
