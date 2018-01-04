using Ninject.Modules;
using Sprout.DL;
using Sprout.DL.Interfaces;
using Sprout.DL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DI.Resolver.Modules
{
    public class DLModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEmployeeDL>().To<EmployeeDL>();
            this.Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
        }
    }
}
