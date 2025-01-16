using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WorldWS.Models;
using WorldWS.Repositories;

namespace WorldWS
{
    /// <summary>
    /// Summary description for WorldService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WorldService : System.Web.Services.WebService
    {

        private readonly WorldRepository _repository = new WorldRepository("Data Source=LAPTOP-536DD52U\\SQLSERVER2022;Initial Catalog=world;Integrated Security=True");

        [WebMethod]
        public List<Country> GetAllCountries()
        {
            var countries = _repository.GetAllCountries();
            if (countries.Count == 0 || countries == null )
            {
                Console.WriteLine("No countries found in the database.");
            }
            return countries;
        }


        [WebMethod]
        public Country GetCountryByCode(string code)
        {
            return _repository.GetCountryByCode(code);
        }

        [WebMethod]
        public List<City> GetCitiesByCountryCode(string code)
        {
            return _repository.GetCitiesByCountryCode(code);
        }

        [WebMethod]
        public City GetCityByName(string name)
        {
            return _repository.GetCityByName(name);
        }
    }
}
