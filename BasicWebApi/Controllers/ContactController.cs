using BasicWebApi.DataAccess.Interfaces;
using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
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
    public class ContactController : ControllerBase
    {
        private  IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }


        // GET: api/<ContactController>
        [HttpGet("getAll")]
        public IActionResult GetAllContacts()
        {
            try
            {
                List<VM_Contact> contacts = _contactService.GetAllContacts();
                return StatusCode(StatusCodes.Status200OK, contacts);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // GET api/<ContactController>/5
        [HttpPost("update")]
        public IActionResult UpdateContact(Contact contact)
        {
            try
            {
                _contactService.Update(contact);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
           
        }

        [HttpDelete("delete/{id}")]
        public ActionResult DeleteContact(int id)
        {
            try
            {
                _contactService.Delete(id);
                return StatusCode(StatusCodes.Status202Accepted);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            
        }

        [HttpPost("create")]
        public IActionResult CreateContact(Contact contact)
        {
            try
            {
                _contactService.Create(contact);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpGet("filter/companyOrCountry")]
        public IActionResult FilterContacts(int countryId, int companyId)
        {

            List<VM_Contact> filteredContacts = _contactService.FilterContact(countryId, companyId);
            if (filteredContacts == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return StatusCode(StatusCodes.Status200OK, filteredContacts);
        }


        [HttpGet("filter/companyAndCountry")]
        public IActionResult FilterContactsCompanyAndCountry()
        {

            List<VM_Contact> filteredContacts = _contactService.GetContactsWithCompanyAndCountry();
            if(filteredContacts == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return StatusCode(StatusCodes.Status200OK, filteredContacts);
        }


    }
}
