using _00009647_seminar3_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00009647_seminar3_.Repository
{
   public interface IProductRepository
    {
        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);

        Product GetProductById(int id);

        IEnumerable<Product> GetProducts();
    }
}
