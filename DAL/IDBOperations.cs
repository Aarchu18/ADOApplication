using System.Collections.Generic;
using ADOModel;

namespace DAL
{
    public interface IDBOperations
    {

       
        int AddProduct(Product product);

        IEnumerable<Product> GetProduct();
    }
}
