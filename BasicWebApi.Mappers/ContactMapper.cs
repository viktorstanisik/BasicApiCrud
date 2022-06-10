using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Mappers
{
    public static class ContactMapper
    {
        public static VM_Contact ToVMContact(Contact contact)
        {
            VM_Contact vmContact = new VM_Contact()
            {
                ContactName = contact.ContactName,
                CompanyName = contact.Company.CompanyName,
                CountryName = contact.Country.CountryName
            };

            return vmContact;
        }

        public static List<VM_Contact> ToVMContactList(List<Contact> contacts)
        {
            List<VM_Contact> vmContacts = new List<VM_Contact>(contacts.Select(x => new VM_Contact()
            {
                CompanyName = x.Company.CompanyName,
                ContactName = x.ContactName,
                CountryName = x.Country.CountryName
            }).ToList());
            return vmContacts;
        }

    }
}
