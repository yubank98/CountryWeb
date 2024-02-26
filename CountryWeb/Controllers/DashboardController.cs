using CountryWeb.Services;
using Microsoft.AspNetCore.Mvc;
using CountryWeb.Models;

namespace CountryWeb.Controllers
{
    public class DashboardController : Controller
    {
        private CountryService _countryService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public DashboardController(CountryService countryService, IWebHostEnvironment hostingEnvironment)
        {
            _countryService = countryService;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index(string countryName)
        {
            string _countryName = countryName ?? "costa rica";
            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "countryname.json");

            string json = System.IO.File.ReadAllText(filePath);
            

            ViewBag.CountriesJson = json;

            var country = await _countryService.GetCountryAsync(_countryName);
            return View(country);
        }
        public async Task<IActionResult> Region()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetCountriesByRegion(string regionName)
        {
            string _regionName = regionName;
            List<Country> countries = await _countryService.GetCountriesByRegionAsync(_regionName);
            return Json(countries);
        }

    }
}
