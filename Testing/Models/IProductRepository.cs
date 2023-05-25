using System.Collections.Generic;

namespace Testing.Models;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}