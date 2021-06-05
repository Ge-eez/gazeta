using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Models
{
    public class User
    {
        [Display(Name = "Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "{0} is required ")]
        public string UserName { get; set; }

        [Key]
        [Display(Name = "Email")]
        [StringLength(100)]
        [Required(ErrorMessage = "{0} is required ")]
        public string UserEmail { get; set; }

        [Display(Name = "Password")]
        [StringLength(100)]
        [Required(ErrorMessage = "{0} is required ")]
        public string UserPassword { get; set; }
    }
}
