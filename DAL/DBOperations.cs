using ADOModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public sealed class DBOperations:IDBOperations
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private string connentionString = @"Data Source=KELLGGNCPU0229\SQLEXPRESS;Initial Catalog=SampleExercise;Integrated Security=True";
        private static readonly object padlock = new object();
        private static DBOperations instance = null;
        private DBOperations()
        {

        }
    
        public static DBOperations Instance()
        {
            
            
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new DBOperations();
                        }
                    }
                }
                return instance;
            
        }
    

    public int AddProduct(Product addProduct)
        {
            using (sqlConnection = new SqlConnection(connentionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("insert into product (ProductName,ProductPrice,ProductCategoryId,DateCreated)values(@ProductName,@ProductPrice,@ProductCategoryId,@DateCreated)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ProductName", addProduct.ProductName);
                sqlCommand.Parameters.AddWithValue("@ProductPrice", addProduct.ProductPrice);
                sqlCommand.Parameters.AddWithValue("@ProductCategoryId", addProduct.ProductCategoryId);
                DateTime currentDate = DateTime.Now;
                string time = currentDate.ToString();
                sqlCommand.Parameters.AddWithValue("@DateCreated", time);
                var result = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                return result;
            }
        }
        public IEnumerable<Product> GetProducts()
        {

            using (sqlConnection = new SqlConnection(connentionString))
            {
                List<Product> ProductList = new List<Product>();
                SqlCommand command = new SqlCommand("SELECT * FROM Product ", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ProductList.Add(new Product()
                    {
                        ProductId = Convert.ToInt32(sqlDataReader[0]),
                        ProductName = sqlDataReader[1].ToString(),
                        ProductPrice = Convert.ToInt32(sqlDataReader[2]),
                        ProductCategoryId = Convert.ToInt32(sqlDataReader[3]),
                        DateCreated = sqlDataReader[4].ToString()
                    });
                }
                if (ProductList.Count > 0)
                {
                    return ProductList;
                }

                return null;
            }
        }
        public Product GetProductId(int productId)
        {
            using (sqlConnection = new SqlConnection(connentionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Product where ProductId =" + productId;
                sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    return new Product
                    {
                        ProductId = Convert.ToInt32(sqlDataReader[0]),
                        ProductName = sqlDataReader[1].ToString(),
                        ProductPrice = Convert.ToInt32(sqlDataReader[2]),
                        ProductCategoryId = Convert.ToInt32(sqlDataReader[3]),
                        DateCreated = sqlDataReader[4].ToString()

                    };
                }
                return null;
            }
        }
        public void UpdateProduct(Product updateProduct)
        {
            using (sqlConnection = new SqlConnection(connentionString))
            {
                updateProduct.DateCreated = DateTime.Now.ToString();
                sqlConnection.Open();
                string query = "UPDATE Product SET " +
                    "ProductName ='" + updateProduct.ProductName +
                    "', ProductPrice = " + updateProduct.ProductPrice +
                    ", ProductCategoryId =" + updateProduct.ProductCategoryId +
                    ", DateCreated ='" + updateProduct.DateCreated
                    + "' where ProductId =" + updateProduct.ProductId;

                sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            }
        }
        public void DeleteProductId(int productId)
        {
            using (sqlConnection = new SqlConnection(connentionString))
            {
                sqlConnection.Open();
                string query = "DELETE FROM Product where ProductId = " + productId;
                sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            }

        }

        
       

    }
}

