using BasicWebApi.DataAccess.Interfaces;
using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
using BasicWebApi.Mappers;
using BasicWebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Services.Implementations
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public List<VM_Contact> GetAllContacts()
        {
            List<VM_Contact> contacts = _contactRepository.GetAllContacts();
            return contacts;
        }

        public List<VM_Contact> FilterContact(int countryId, int companyId)
        {
            List<VM_Contact> contacts = _contactRepository.FilterContact(countryId, companyId);
            return contacts;
        }


        public List<VM_Contact> GetContactsWithCompanyAndCountry()
        {
            return _contactRepository.GetContactsWithCompanyAndCountry();
        }

        public void Create(Contact entity)
        {
            _contactRepository.Create(entity);
        }

        public void Update(Contact entity)
        {
            _contactRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

    }
}
