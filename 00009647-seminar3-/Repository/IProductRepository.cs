using _00009647_seminar3_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00009647_seminar3_.Repository
{
    //what is interface?
    //An interface allows you to get the person to do the work they are assigned to,
    //without you having the knowledge of exactly who they are or the specifics of what they can do.
    //This allows you to easily add new types (of trade) without changing your existing code
    //(well technically you do change it a tiny tiny bit), and that's the real benefit of an OOP approach
    //vs. a more functional programming methodology.
    public interface IProductRepository
    {
        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);

        Product GetProductById(int id);

        IEnumerable<Product> GetProducts();
    }
}
