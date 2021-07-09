using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM adventureworks_products;");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM adventureworks_products WHERE ProductKey = @id",
                new { id = id });

        }

        public void UpdateProduct(Product product)
        {
            _ = _conn.Execute("UPDATE adventureworks_products SET ProductName = @Name, ProductPrice = @Price WHERE ProductKey = @key",
                new { name = product.ProductName, price = product.ProductPrice, key = product.ProductKey });
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO adventureworks_products (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);",
                new { name = productToInsert.ProductName, price = productToInsert.ProductPrice, categoryID = productToInsert.ProductKey });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM adventureworks_territories;");
        }


        public Product AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new Product();
            product.Categories = categoryList;

            return product;
        }

        public void DeleteProduct(Product product)
        {
            
            _conn.Execute("DELETE FROM adventureworks_products WHERE ProductKey = @id;",
                                       new { id = product.ProductKey });
        }


    }
}
