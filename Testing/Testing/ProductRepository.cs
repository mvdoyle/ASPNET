using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumberable<Product> GetAllProducts()
        {
            return (IEnumberable<Product>)_conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
