using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public interface IEmployeesRepository
    {
        public IEnumerable<Employees> GetAllEmployees();
        public Employees GetEmployees(int id);
    }
}
