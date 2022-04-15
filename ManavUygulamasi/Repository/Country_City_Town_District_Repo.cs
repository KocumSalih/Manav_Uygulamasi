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
    class Country_City_Town_District_Repo
    {
        private SqlConnection connection;
        private string connectionString;

        public Country_City_Town_District_Repo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public List<City> GetCities()
        {
            List<City> cities = new List<City>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_GetCities", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    City city = new City();
                    city.CityId = Convert.ToInt32(reader["SehirId"]);
                    city.CityName = reader["SehirAdi"].ToString();

                    cities.Add(city);
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
            return cities;
        }

        public List<Town> GetTowns(City city)
        {
            List<Town> towns = new List<Town>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_GetTowns", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SehirId", city.CityId);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Town town = new Town();
                    town.CityId = Convert.ToInt32(reader["SehirId"]);
                    town.TownId = Convert.ToInt32(reader["ilceId"]);
                    town.TownName = reader["IlceAdi"].ToString();

                    towns.Add(town);
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
            return towns;
        }

        public List<District> GetDistricts(Town town)
        {
            List<District> districts = new List<District>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_GetDistricts", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IlceId", town.TownId);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    District district = new District();
                    district.DistrictId = Convert.ToInt32(reader["SemtMahId"]);
                    district.DistrictName = reader["MahalleAdi"].ToString();
                    district.TownId = Convert.ToInt32(reader["ilceId"]);

                    districts.Add(district);
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
            return districts;
        }
    }
}
