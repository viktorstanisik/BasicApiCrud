using BasicWebApi.DataAccess.Interfaces;
using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain;
using BasicWebApi.Domain.ViewModels;
using BasicWebApi.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.DataAccess.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly BasicWebApiDbContext _db;

        public ContactRepository(BasicWebApiDbContext db)
        {
            _db = db;
        }

        public void Create(Contact entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
        }


        public void Delete(int id)
        {
            Contact contact = _db.Contact.FirstOrDefault(x => x.ContactId == id);
            _db.Remove(contact);
            _db.SaveChanges();
        }

        public List<Contact> GetAll()
        {
            return _db.Contact.ToList();
        }

        public List<VM_Contact> GetAllContacts()
        {
            List<Contact> contacts = _db.Contact
                .Include(x => x.Company)
                .Include(x => x.Country)
                .ToList();
            return ContactMapper.ToVMContactList(contacts);
        }

        public void Update(Contact entity)
        {
            _db.Contact.Update(entity);
            _db.SaveChanges();

        }

        public List<VM_Contact> FilterContact(int countryId, int companyId)

        {
            List<Contact> contacts = _db.Contact
               .Include(x => x.Company)
               .Include(x => x.Country)
               .Where(x => x.CountryId == countryId || x.CompanyId == companyId)
               .ToList();
       

            return ContactMapper.ToVMContactList(contacts);
            
        }

        public List<VM_Contact> GetContactsWithCompanyAndCountry()
        {
            List<Contact> contacts = _db.Contact
            .Include(x => x.Company)
            .Include(x => x.Country)
            .Where(x => x.CountryId != null && x.CompanyId != null).ToList();
        
            return ContactMapper.ToVMContactList(contacts);

        }


    }
}
