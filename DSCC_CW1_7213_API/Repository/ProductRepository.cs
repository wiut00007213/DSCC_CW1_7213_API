using DSCC_CW1_7213_API.DbContexts;
using DSCC_CW1_7213_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC_CW1_7213_API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;
        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(product);
            Save();

        }

        public Product GetProductById(int id)
        {
            var prod = _dbContext.Products.Find(id);
            return prod;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();

        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
