using Sprout.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DL.Interfaces
{
    public interface IEmployeeDL
    {
        IEnumerable<EmployeeDto> GetAll();
        EmployeeDto GetById(int Id);
    }
}
