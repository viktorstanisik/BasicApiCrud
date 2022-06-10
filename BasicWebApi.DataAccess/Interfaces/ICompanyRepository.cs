using BasicWebApi.DataAccess.Models;
using BasicWebApi.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.DataAccess.Interfaces
{
    public interface ICompanyRepository : IRepository<Company> { }
}
