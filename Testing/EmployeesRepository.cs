using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly IDbConnection _conn;
        public EmployeesRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return _conn.Query<Employees>("SELECT * FROM EMPLOYEES");
        }

        public Employees GetEmployees(int id)
        {
            return _conn.QuerySingle<Employees>("SELECT * FROM EMPLOYEES WHERE EMPLOYEEID = @id",
                new { id = id });

        }
    }
}   
