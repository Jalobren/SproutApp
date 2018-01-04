using Sprout.DTO;
using Sprout.WebApp.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sprout.WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IWebClient _webClient;
        public EmployeeController(IWebClient webClient)
        {
            _webClient = webClient;
        }

        // GET: Employees
        public async Task<ActionResult> Index()
        {
            var employees = await _webClient.GetAsync<IEnumerable<EmployeeDto>>("Employee/GetAll");
            return View(employees);
        }
    }
}