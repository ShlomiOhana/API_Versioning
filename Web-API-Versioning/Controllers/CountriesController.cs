using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.Models.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API_Versioning.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class CountriesController : ControllerBase
    {
        // GET: api/<CountriesController>
        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
        {
            var countriesDomainModel = CountriesData.Get();

            var response = new List<CountryDtoV1>();
            foreach (var country in countriesDomainModel)
            {
                response.Add(new CountryDtoV1
                {
                    Id = country.Id,
                    Name = country.Name,
                });
            }

            return Ok(response);
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
        {
            var countriesDomainModel = CountriesData.Get();

            var response = new List<CountryDtoV2>();
            foreach (var country in countriesDomainModel)
            {
                response.Add(new CountryDtoV2
                {
                    Id = country.Id,
                    CountryName = country.Name,
                });
            }

            return Ok(response);
        }
    }
}
