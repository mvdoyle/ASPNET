using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public interface ICategoriesRepository
    {
        public IEnumerable<Category> GetAllCategories();

    }
}
