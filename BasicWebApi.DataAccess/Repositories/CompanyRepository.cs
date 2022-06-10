using BasicWebApi.DataAccess.Interfaces;
using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain;
using System.Collections.Generic;
using System.Linq;

namespace BasicWebApi.DataAccess.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BasicWebApiDbContext _db;

        public CompanyRepository(BasicWebApiDbContext db)
        {
            _db = db;
        }

        public void Create(Company entity)
        {
            _db.Company.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Company company = _db.Company.FirstOrDefault(x => x.CompanyId == id);
            _db.Company.Remove(company);
            _db.SaveChanges();
        }

        public List<Company> GetAll()
        {
            return _db.Company.ToList();
        }

        public void Update(Company entity)
        {
            _db.Company.Update(entity);
            _db.SaveChanges();
        }

    }
}
