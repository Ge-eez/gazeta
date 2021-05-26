using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ProfileImage { get; set; }
        public string Owner { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
