using AutoMapper;
using Sprout.DL.Interfaces;
using Sprout.DL.Repo;
using Sprout.DTO;
using Sprout.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DL
{
    public class EmployeeDL : IEmployeeDL
    {
        private readonly IRepository<Employee> _employeeRepositoy;
        private readonly IMapper _mapper;

        public EmployeeDL(IRepository<Employee> employeeRepo, IMapper mapper)
        {
            _employeeRepositoy = employeeRepo;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all Employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeDto> GetAll()
        {
            return _mapper.Map<IEnumerable<EmployeeDto>>(_employeeRepositoy.All());
        }
        
        /// <summary>
        /// Get Employee by Id
        /// </summary>
        /// <returns></returns>
        public EmployeeDto GetById(int Id)
        {
            return _mapper.Map<EmployeeDto>(_employeeRepositoy.FindBy(x=>x.Id == Id).FirstOrDefault());
        }
    }
}
