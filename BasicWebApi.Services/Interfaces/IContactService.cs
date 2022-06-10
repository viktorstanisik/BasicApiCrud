using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Services.Interfaces
{
   public interface IContactService
    {
        List<VM_Contact> GetAllContacts();
        List<VM_Contact> GetContactsWithCompanyAndCountry();
        List<VM_Contact> FilterContact(int countryId, int companyId);
        void Create(Contact entity);
        void Update(Contact entity);
        void Delete(int id);
    }
}
