using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesRepository repo;

        public SalesController(ISalesRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var sales = repo.GetAllSales();

            return View(sales);
        }
        public IActionResult ViewSales(int id)
        {
            var sales = repo.GetSales(id);

            return View(sales);
        }

    }
}
