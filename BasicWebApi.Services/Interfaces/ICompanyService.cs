using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Services.Interfaces
{
   public interface ICompanyService
    {
        void Create(Company entity);
        void Update(Company entity);
        List<Company> GetAll();
        void Delete(int id);

    }
}
