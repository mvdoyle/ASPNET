using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Sales
    {
        public Sales()
        {

        }

        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
    }
}
