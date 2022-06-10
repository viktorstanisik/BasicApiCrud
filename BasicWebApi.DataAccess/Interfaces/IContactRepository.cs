using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.DataAccess.Interfaces
{
    public interface IContactRepository : IRepository<Contact>
    {
        List<VM_Contact> GetAllContacts();
        List<VM_Contact> GetContactsWithCompanyAndCountry();
        List<VM_Contact> FilterContact(int countryId, int companyId);

    }
}
