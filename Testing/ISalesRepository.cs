using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public interface ISalesRepository
    {
        public IEnumerable<Sales> GetAllSales();
        public Sales GetSales(int id);
    }
}
