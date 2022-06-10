using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.DataAccess.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public int? CompanyId { get; set; }
        public int? CountryId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        
    }
}
