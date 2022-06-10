using BasicWebApi.DataAccess.Models;
using BasicWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllCompanies()
        {
            try
            {
                List<Company> company = _companyService.GetAll();
                return StatusCode(StatusCodes.Status200OK, company);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPost("update")]
        public IActionResult UpdateCompany(Company company)
        {
            try
            {
                _companyService.Update(company);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpDelete("delete/{id}")]
        public ActionResult DeleteCompany(int id)
        {
            try
            {
                _companyService.Delete(id);
                return StatusCode(StatusCodes.Status202Accepted);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPost("create")]
        public IActionResult CreateCompany(Company company)
        {
            try
            {
                _companyService.Create(company);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }
    }
}
