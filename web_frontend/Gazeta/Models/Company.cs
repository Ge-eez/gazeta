using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Models
{
    //public class Company
    //{
    //    [Display(Name = "Name")]
    //    [StringLength(100)]
    //    [Required(ErrorMessage = "{0} is required ")]
    //    public string CompanyName { get; set; }

    //    [Key]
    //    [Display(Name = "Email")]
    //    [StringLength(100)]
    //    [Required(ErrorMessage = "{0} is required ")]
    //    public string CompanyEmail { get; set; }

    //    [Display(Name = "Password")]
    //    [StringLength(100)]
    //    [Required(ErrorMessage = "{0} is required ")]
    //    public string CompanyPassword { get; set; }
    //    [Display(Name = "Owner Name")]
    //    public string Owner { get; set; }

    //    [Display(Name = "Company Logo")]
    //    public string ProfileImage { get; set; }

    //    [NotMapped]
    //    [Display(Name = "Upload file")]
    //    public IFormFile ImageFile { get; set; }


    //}
    public class Company
    {

        [Display(Name = "Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "{0} is required ")]
        public string CompanyName { get; set; }

        [Key]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} is required ")]
        public string CompanyEmail { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} is required ")]
        public string CompanyPassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} is required ")]
        [Compare("CompanyPassword", ErrorMessage = "Must match with password")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Address")]
        [StringLength(100)]
        public string Address { get; set; }
        [Display(Name = "City")]
        [StringLength(100)]
        public string City { get; set; }

        [Display(Name = "Description")]
        [StringLength(1000)]
        public string Description { get; set; }

        [Display(Name = "Owner Name")]
        public string Owner { get; set; }

        [Display(Name = "Image file Name")]
        public string ProfileImage { get; set; }

        [NotMapped]
        [Display(Name = "Upload Image")]
        public IFormFile ImageFile { get; set; }



    }
}
