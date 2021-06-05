using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Models
{
    public class Subscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Company Email")]
        [Required(ErrorMessage = "{0} is required ")]
        public string CompanyName { get; set; }

        [Display(Name = "User Email")]
        [Required(ErrorMessage = "{0} is required ")]
        public string UserEmail { get; set; }

        [Display(Name = "Company Email")]
        [Required(ErrorMessage = "{0} is required ")]
        public string CompanyEmail { get; set; }


    }
}
