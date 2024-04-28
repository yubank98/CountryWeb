using CountryWeb.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CountryWeb.Services
{
    public class CountryService
    {
        private readonly HttpClient _httpClient;

        private String _baseUrl = "https://restcountries.com/v3.1/";
        private String _fieldsUrl = "?fields=name,flags,independent,officialNames,cioc,region,subregion,languages,latlng,borders,area,demonyms,capital,currencies,population";

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<Country?> GetCountryAsync(string countryName)
        {
            var response = await _httpClient.GetAsync(_baseUrl+$"name/{countryName}"+_fieldsUrl);
            
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
                var content = await response.Content.ReadAsStringAsync();
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(content);

                return countries[0];


            }
            else
            {
                return null;
            }
           
        }

        public async Task<List<Country?>> GetCountriesByRegionAsync(string regionName)
        {
            var response = await _httpClient.GetAsync(_baseUrl + $"region/{regionName}");
            
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
                var content = await response.Content.ReadAsStringAsync();
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(content);

                return countries;
            }
            else
            {
                return null;
            }
        }
      
    }
}