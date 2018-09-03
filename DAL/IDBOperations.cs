using System.Collections.Generic;
using ADOModel;

namespace DAL
{
    public interface IDBOperations
    {
        int AddProduct(Product product);

        IEnumerable<Product> GetProducts();
        void DeleteProductId(int productId);
        void UpdateProduct(Product product);
        Product GetProductId(int id);
    }
}
