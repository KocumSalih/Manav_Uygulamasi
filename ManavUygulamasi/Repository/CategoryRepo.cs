
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavUygulamasi.Repository
{
    using Entities;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    class CategoryRepo : IRepository<Category>
    {
        private SqlConnection connection;
        private string connectionString;


        public CategoryRepo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public void Add_Update(Category item)
        {
            try
            {
                SqlCommand command = new SqlCommand("Sp_Add_Update", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@categoryId", item.CategoryId);
                command.Parameters.AddWithValue("@CategoryName", item.CategoryName);
                command.Parameters.AddWithValue("@Description", item.Description);
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(Category item)
        {
            try
            {
                SqlCommand command = new SqlCommand("Sp_Delete_Category", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@categoryId", item.CategoryId);
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Category> Get()
        {
            List<Category> categories = new List<Category>();

            try
            {
                SqlCommand command = new SqlCommand("Sp_GetCategories", connection);
                command.CommandType = CommandType.StoredProcedure;
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category();
                    category.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    category.CategoryName = reader["CategoryName"].ToString();
                    category.Description = reader["Description"].ToString();
                    categories.Add(category);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return categories;
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
