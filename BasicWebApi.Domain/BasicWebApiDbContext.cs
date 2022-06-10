using BasicWebApi.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Domain
{
    public class BasicWebApiDbContext : DbContext
    {
        public BasicWebApiDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Company> Company { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Country> Country { get; set; }

    }
}
