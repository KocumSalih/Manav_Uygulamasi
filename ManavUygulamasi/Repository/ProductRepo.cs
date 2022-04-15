using ManavUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavUygulamasi.Repository
{
    class ProductRepo : IRepository<Product>
    {
        private SqlConnection connection;
        private string connectionString;
        public ProductRepo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public void Add_Update(Product item)
        {
            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Add_Update", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ProductId", item.ProductId);
                command.Parameters.AddWithValue("ProductName", item.ProductName);
                command.Parameters.AddWithValue("CategoryId", item.CategoryId);
                command.Parameters.AddWithValue("QuantityPerUnit", item.QuantityPerUnit);
                command.Parameters.AddWithValue("UnitPrice", item.UnitPrice);
                command.Parameters.AddWithValue("UnitsInStock", item.UnitsInStock);
                command.Parameters.AddWithValue("UnitsOnOrder", item.UnitsOnOrder);
                command.Parameters.AddWithValue("Discontinued", item.Discontinued);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(Product item)
        {
            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Delete", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ProductId", item.ProductId);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Product> Get()
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Get_Products_List", connection);
                command.CommandType = CommandType.StoredProcedure;
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    product.QuantityPerUnit = reader["QuantityPerUnit"].ToString();
                    product.CategoryName = reader["CategoryName"].ToString();
                    product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    product.UnitsInStock = Convert.ToInt16(reader["UnitsInStock"]);
                    product.UnitsOnOrder = Convert.ToInt16(reader["UnitsOnOrder"]);
                    product.Discontinued = Convert.ToBoolean(reader["Discontinued"]);
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return products;
        }

        public Product GetByID(int id)
        {
            Product product=new Product();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Find_Product_With_Id", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ProductId",id);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    product.QuantityPerUnit = reader["QuantityPerUnit"].ToString();
                    product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
                    product.UnitsInStock = Convert.ToInt16(reader["UnitsInStock"]);
                    product.UnitsOnOrder = Convert.ToInt16(reader["UnitsOnOrder"]);
                    product.Discontinued = Convert.ToBoolean(reader["Discontinued"]);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return product;
        }
    }
}
