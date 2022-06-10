using BasicWebApi.DataAccess.Interfaces;
using BasicWebApi.DataAccess.Models;
using BasicWebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Services.Implementations
{
    public class CountryService : ICountryService
    {
        private ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public void Create(Country entity)
        {
            _countryRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _countryRepository.Delete(id);
        }

        public List<Country> GetAll()
        {
            return _countryRepository.GetAll();
        }

        public void Update(Country entity)
        {
            _countryRepository.Update(entity);
        }
    }
}
