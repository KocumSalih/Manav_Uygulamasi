using ManavUygulamasi.Entities;
using ManavUygulamasi.VM;
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
    class CustomerRepo : IRepository<Customer>
    {
        private SqlConnection connection;
        private string connectionString;

        public CustomerRepo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public void Add_Update(Customer item)
        {
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer__Insert_Update", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId", item.CustomerId);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@CityId", item.CityId);
                command.Parameters.AddWithValue("@TownId", item.TownId);
                command.Parameters.AddWithValue("@DistrictId", item.DistrictId);
                command.Parameters.AddWithValue("@Phone", item.Phone);
                //command.Parameters.AddWithValue("@District",item.District);
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

        public void Delete(Customer item)
        {
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_Delete", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId", item.CustomerId);
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

        public List<Customer> Get()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                SqlCommand command = new SqlCommand("Sp_Get_Customer_List", connection);
                command.CommandType = CommandType.StoredProcedure;
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.CityId = Convert.ToInt32(reader["CityId"]); 
                    customer.TownId = Convert.ToInt32(reader["TownId"]);
                    customer.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    customer.Phone = reader["Phone"].ToString();
                    
                    customers.Add(customer);
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
            return customers;
        }

        public Customer GetByID(int id)
        {
            Customer customer = new Customer();
            try
            {
                SqlCommand command = new SqlCommand("SP_Find_Customer_With_Id",connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId",id);

                if (connection.State==ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    customer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.CityId = Convert.ToInt32(reader["CityId"]);
                    customer.TownId = Convert.ToInt32(reader["TownId"]);
                    customer.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    customer.Phone = reader["Phone"].ToString();                    
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return customer;
        }

        public List<Vm_Customer> GetVm_Customers()
        {
            List<Vm_Customer> customers = new List<Vm_Customer>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_With_City_Town_District", connection);
                command.CommandType = CommandType.StoredProcedure;

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Vm_Customer customer = new Vm_Customer();
                    customer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    customer.CityId = Convert.ToInt32(reader["CityId"]);
                    customer.TownId = Convert.ToInt32(reader["TownId"]);
                    customer.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.Phone = reader["Phone"].ToString();
                    customer.CityName = reader["CityName"].ToString();
                    customer.TownName = reader["TownName"].ToString();
                    customer.DistrictName = reader["DistrictName"].ToString();

                    customers.Add(customer);
                }
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return customers;
        }
        public Vm_Customer GetVm_Customer(int customerId)
        {
            Vm_Customer customer=null;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_With_City_Town_District", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId",customerId);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    customer = new Vm_Customer();
                    customer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    customer.CityId = Convert.ToInt32(reader["CityId"]);
                    customer.TownId = Convert.ToInt32(reader["TownId"]);
                    customer.DistrictId = Convert.ToInt32(reader["DistrictId"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.Phone = reader["Phone"].ToString();
                    customer.CityName = reader["CityName"].ToString();
                    customer.TownName = reader["TownName"].ToString();
                    customer.DistrictName = reader["DistrictName"].ToString();

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return customer;
        }
    }
}
