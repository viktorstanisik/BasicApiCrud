using BasicWebApi.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Services.Interfaces
{
    public interface ICountryService
    {
        void Create(Country entity);
        void Update(Country entity);
        List<Country> GetAll();
        void Delete(int id);
    }
}
