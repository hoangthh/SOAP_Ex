using System;
using System.Linq;
using System.Windows.Forms;
using WorldServiceReference;

namespace WorldClient
{
    public partial class Form1 : Form
    {
        private WorldServiceSoapClient _client;
        public Form1()
        {
            InitializeComponent();
            _client = new WorldServiceSoapClient(WorldServiceSoapClient.EndpointConfiguration.WorldServiceSoap);
        }

        private void btnGetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                var res = _client.GetAllCountriesAsync().Result;
                var countries = res.Body.GetAllCountriesResult;
                dataGridViewCountries.Rows.Clear();

                foreach (var country in countries)
                {
                    dataGridViewCountries.Rows.Add(country.Code, country.Name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewCountries.Columns.Clear();
            dataGridViewCountries.Columns.Add("Code", "Country Code");
            dataGridViewCountries.Columns.Add("Name", "Country Name");

            dataGridViewCity.Columns.Clear();
            dataGridViewCity.Columns.Add("ID", "ID");
            dataGridViewCity.Columns.Add("Name", "Name");
            dataGridViewCity.Columns.Add("CountryCode", "Country Code");
            dataGridViewCity.Columns.Add("District", "District");
        }

        private void btnGetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = txtCountryCode.Text;
                var res = _client.GetCountryByCodeAsync(countryCode).Result;

                if (res == null || res.Body == null || res.Body.GetCountryByCodeResult == null)
                {
                    MessageBox.Show($"No country found with code {countryCode}");
                    return;
                }

                var country = res.Body.GetCountryByCodeResult;

                if (country != null)
                {
                    dataGridViewCountries.Rows.Clear();
                    dataGridViewCountries.Rows.Add(country.Code, country.Name);
                }
                else
                {
                    MessageBox.Show($"No country found for the code {countryCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGetCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = txtCityName.Text;
                var res = _client.GetCityByNameAsync(cityName).Result;

                if (res == null || res.Body == null || res.Body.GetCityByNameResult == null)
                {
                    MessageBox.Show($"No city found with name {cityName}");
                    return;
                }

                var city = res.Body.GetCityByNameResult;

                if (city != null)
                {
                    dataGridViewCity.Rows.Clear();
                    dataGridViewCity.Rows.Add(city.ID, city.Name, city.CountryCode, city.District);
                }
                else
                {
                    MessageBox.Show($"No city found for the name {cityName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGetCitiesByCountryCode_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = txtCountryCodeCities.Text;
                var res = _client.GetCitiesByCountryCodeAsync(countryCode).Result;

                if (res?.Body?.GetCitiesByCountryCodeResult == null || !res.Body.GetCitiesByCountryCodeResult.Any())
                {
                    MessageBox.Show($"No cities found for country code {countryCode}");
                    return;
                }

                var cities = res.Body.GetCitiesByCountryCodeResult;

                if (cities != null && cities.Any())
                {
                    dataGridViewCity.Rows.Clear();

                    foreach (var city in cities)
                    {
                        dataGridViewCity.Rows.Add(city.ID, city.Name, city.CountryCode, city.District);
                    }
                }
                else
                {
                    MessageBox.Show($"No cities found for the country code {countryCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
