using BasicWebApi.DataAccess.Interfaces;
using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.DataAccess.Repositories
{
    public class CountryRepository : ICountryRepository
    {

        private readonly BasicWebApiDbContext _dbContext;

        public CountryRepository(BasicWebApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Country entity)
        {
            _dbContext.Country.Add(entity);
            _dbContext.SaveChanges();

        }

        public void Delete(int id)
        {
            Country country = _dbContext.Country.SingleOrDefault(x => x.CountryId == id);
            if (country == null)
            {
                throw new Exception("No such user");
            }
            _dbContext.Country.Remove(country);
        }

        public List<Country> GetAll()
        {
           return _dbContext.Country.ToList();
        }

        public void Update(Country entity)
        {
            _dbContext.Country.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
