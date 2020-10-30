using DSCC_CW1_7213_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC_CW1_7213_API.Repository
{
    public interface IProductRepository
    {
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
    }
}
