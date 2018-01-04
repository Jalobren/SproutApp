using Sprout.BL.Interfaces;
using Sprout.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sprout.WebApi.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeBL _employeeBL;
        public EmployeeController(IEmployeeBL employeeBL)
        {
            _employeeBL = employeeBL;
        }

        [Route("getAll/")]
        public IEnumerable<EmployeeDto> GetAll()
        {
            return _employeeBL.GetAll();
        }
    }
}
