using Sprout.BL.Interfaces;
using Sprout.DL;
using Sprout.DL.Interfaces;
using Sprout.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.BL
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeDL _employeeDL; 

        public EmployeeBL(IEmployeeDL employeeDL)
        {
            _employeeDL = employeeDL;
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeDto> GetAll()
        {
            return _employeeDL.GetAll();
        }

        public EmployeeDto GetById(int Id)
        {
            return _employeeDL.GetById(Id);
        }
    }
}
