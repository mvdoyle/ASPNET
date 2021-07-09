using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Testing 
{
    public class CategoryRepository
    {
        private readonly IDbConnection _conn;

        public CategoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }
    }
}
