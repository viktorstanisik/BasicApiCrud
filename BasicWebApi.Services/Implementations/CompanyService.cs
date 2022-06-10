using BasicWebApi.DataAccess.Interfaces;
using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
using BasicWebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Services.Implementations
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void Create(Company entity)
        {
            _companyRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _companyRepository.Delete(id);
        }

        public List<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }

        public void Update(Company entity)
        {
            _companyRepository.Update(entity);
        }
    }
}
