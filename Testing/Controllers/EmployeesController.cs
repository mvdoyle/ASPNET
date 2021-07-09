using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesRepository repo;

        public EmployeesController(IEmployeesRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var employees = repo.GetAllEmployees();

            return View(employees);
        }
        public IActionResult ViewEmployees(int id)
        {
            var employees = repo.GetEmployees(id);

            return View(employees);
        }


    }
}
