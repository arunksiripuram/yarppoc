using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCountries()
        {
            var countries = new[]
            {
            new { Code = "US", Name = "United States" },
            new { Code = "IN", Name = "India" },
            new { Code = "UK", Name = "United Kingdom" }
        };
            return Ok(countries);
        }
    }
}
