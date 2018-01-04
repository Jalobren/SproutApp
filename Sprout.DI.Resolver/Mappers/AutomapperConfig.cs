using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DI.Resolver.Mappers
{
    public class AutomapperConfig
    {
        public static IMapper AutoMapper(Ninject.Activation.IContext context)
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EmployeeProfile>();
            });

            Mapper.AssertConfigurationIsValid(); // optional
            return Mapper.Instance;
        }
    }
}
