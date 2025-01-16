using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WorldWS.Models;

namespace WorldWS.Repositories
{
    public class WorldRepository
    {
        private readonly string _connectionString;

        public WorldRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Country> GetAllCountries()
        {
            var countries = new List<Country>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT Code, Name FROM Country";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        countries.Add(new Country
                        {
                            Code = reader["Code"].ToString(),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
            }
            return countries;
        }

        public Country GetCountryByCode(string code)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT Code, Name FROM Country WHERE Code = @Code";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", code);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Country
                            {
                                Code = reader["Code"].ToString(),
                                Name = reader["Name"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<City> GetCitiesByCountryCode(string code)
        {
            var cities = new List<City>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT ID, Name, CountryCode, District FROM City WHERE CountryCode = @Code";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", code);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cities.Add(new City
                            {
                                ID = int.Parse(reader["ID"].ToString()),
                                Name = reader["Name"].ToString(),
                                CountryCode = reader["CountryCode"].ToString(),
                                District = reader["District"].ToString()
                            });
                        }
                    }
                }
            }
            return cities;
        }

        public City GetCityByName(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT ID, Name, CountryCode, District FROM City WHERE Name = @Name";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new City
                            {
                                ID = int.Parse(reader["ID"].ToString()),
                                Name = reader["Name"].ToString(),
                                CountryCode = reader["CountryCode"].ToString(),
                                District = reader["District"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}