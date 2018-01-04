using AutoMapper;
using Sprout.DTO;
using Sprout.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DI.Resolver.Mappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile() : base(nameof(EmployeeProfile))
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
