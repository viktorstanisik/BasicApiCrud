using BasicWebApi.DataAccess.Models;
using BasicWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }



        [HttpGet("getAll")]
        public IActionResult GetAllCountries()
        {
            try
            {
                List<Country> countries = _countryService.GetAll();
                return StatusCode(StatusCodes.Status200OK, countries);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPost("update")]
        public IActionResult UpdateCountry(Country country)
        {
            try
            {
                _countryService.Update(country);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpDelete("delete/{id}")]
        public ActionResult DeleteCountry(int id)
        {
            try
            {
                _countryService.Delete(id);
                return StatusCode(StatusCodes.Status202Accepted);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPost("create")]
        public IActionResult CreateCountry(Country country)
        {
            try
            {
                _countryService.Create(country);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }

}
