using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ADOModel;

namespace DAL
{
    public class DBOperations:IDBOperations
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataAdapter adp;
        private string connStr = @"Data Source=KELLGGNCPU0229\SQLEXPRESS;Initial Catalog=SampleExercise;Integrated Security=True";

        public int AddProduct(Product productbj)
        {
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                cmd = new SqlCommand("insert into product (ProductName,ProductPrice,ProductCategoryId,DateCreated)values(@ProductName,@ProductPrice,@ProductCategoryId,@DateCreated)", conn);
                cmd.Parameters.AddWithValue("@ProductName", productbj.ProductName);
                cmd.Parameters.AddWithValue("@ProductPrice", productbj.ProductPrice);
                cmd.Parameters.AddWithValue("@ProductCategoryId", productbj.ProductCategoryId);
                DateTime currentDate = DateTime.Now;
                string time = currentDate.ToString();
                cmd.Parameters.AddWithValue("@DateCreated", time);
                var result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
        }
        public IEnumerable<Product> GetProduct()
        {

            using (conn = new SqlConnection(connStr))
            {
                List<Product> allProduct = new List<Product>();
                SqlCommand command = new SqlCommand("SELECT * FROM Product ", conn);
                conn.Open();
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    allProduct.Add(new Product()
                    {
                        ProductId = Convert.ToInt32(rd["ProductId"]),
                        ProductName = rd["ProductName"].ToString(),
                        ProductPrice = Convert.ToInt32(rd["ProductPrice"]),
                        ProductCategoryId = Convert.ToInt32(rd["ProductCategoryId"]),
                        DateCreated = rd["DateCreated"].ToString()
                    });
                }
                if (allProduct.Count > 0)
                {
                    return allProduct;
                }

                return null;
            }
        }
        public Product GetProductId(int productId)
        {
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Product where ProductId =" + productId;
                cmd = new SqlCommand(query, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    return new Product
                    {
                        ProductId = Convert.ToInt32(dr[0]),
                        ProductName = dr["ProductName"].ToString(),
                        ProductPrice = Convert.ToInt32(dr["ProductPrice"]),
                        ProductCategoryId = Convert.ToInt32(dr["ProductCategoryId"]),
                        DateCreated = dr["DateCreated"].ToString()

                    };
                }
                return null;
            }
        }


        //public IEnumerable<Product> GetProduct(int productId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product GetProductById(int productId)
        //{
        //    using (conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandText = "Usp_GetProductById";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Id", productId);
        //        var dr = cmd.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            dr.Read();
        //            return new Product
        //            {

        //                ProductName = dr[1].ToString(),
        //                ProductPrice = Convert.ToInt32(dr[2]),
        //                ProductCategoryId = Convert.ToInt32(dr[3]),
        //                DateCreated =dr[4].ToString()

        //            };
        //        }
        //        return null;
        //    }

        //}

        //public IEnumerable<Product> GetProducts()
        //{
        //    throw new NotImplementedException();
        //}

        //public int UpdateProduct(Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Product> GetProducts()
        //{

        //    using (adp = new SqlDataAdapter("select * from Product", connStr))
        //    {
        //        var ds = new DataSet();
        //        adp.Fill(ds);
        //        if (ds.Tables.Count > 0)
        //        {
        //            var products = ds.Tables[0].AsEnumerable().Select(x => new Product
        //            {
        //               ProductId = Convert.ToInt32(x[0]),
        //                ProductName = Convert.ToString(x["ProductName"]),
        //                ProductPrice = Convert.ToString(x[2]),
        //                ProductCategoryId = Convert.ToString(x["Phone"]),
        //                DateCreated = Convert.ToString(x[4]),
        //            });
        //            return products;
        //        }
        //        return null;
        //    }
        //}

        //public int UpdateProduct(Product product)
        //{
        //    using (conn = new SqlConnection(connStr))
        //    {
        //        adp = new SqlDataAdapter("select * from product", conn);
        //        SqlCommandBuilder sb = new SqlCommandBuilder(adp);
        //        var ds = new DataSet();
        //        adp.Fill(ds);
        //        DataRow drNew = (from f in ds.Tables[0].AsEnumerable()
        //                         where f.Field<int>(0) == product.ProductId
        //                         select f).First();
        //        drNew.SetField<string>("ProductName", product.ProductName);
        //        drNew.SetField<int>("ProductPrice", product.ProductPrice);
        //        drNew.SetField<int>("ProductCategoryId", product.ProductCategoryId);
        //        drNew.SetField<string>("DateCreated", product.DateCreated);
        //        return adp.Update(ds);

        //    }
        //}

    }
}

