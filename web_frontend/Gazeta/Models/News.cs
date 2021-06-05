using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Models
{
    //public class News
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int NewsId { get; set; }

    //    [Display(Name = "Headline")]
    //    [StringLength(200)]
    //    [Required(ErrorMessage = "{0} is required ")]
    //    public string Headline { get; set; }

    //    [Display(Name = "URL of the image")]
    //    [StringLength(500)]
    //    public string ImageURL { get; set; }

    //    [Display(Name = "Article")]
    //    [Required(ErrorMessage = "{0} is required ")]
    //    public string Article { get; set; }

    //    [Display(Name = "Published date")]
    //    [Required(ErrorMessage = "{0} is required ")]
    //    public DateTime PublishDate { get; set; }

    //    [Display(Name = "Posted by")]
    //    // [Required(ErrorMessage = "{0} is required ")]
    //    public string CompanyEmail { get; set; }

    //    [Display(Name = "Posted by")]
    //    // [Required(ErrorMessage = "{0} is required ")]
    //    public string CompanyName { get; set; }

    //    [Display(Name = "Number of Likes")]
    //    public int? Likes { get; set; }

    //    [Display(Name = "Category")]
    //    public string Genre { get; set; }

    //    [NotMapped]
    //    [Display(Name = "Upload file")]
    //    public IFormFile ImageFile { get; set; }
    //}
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NewsId { get; set; }

        [Display(Name = "Headline")]
        [StringLength(200)]
        [Required(ErrorMessage = "{0} is required ")]
        public string Headline { get; set; }

        [Display(Name = "URL of the image")]
        [StringLength(500)]
        public string ImageURL { get; set; }

        [Display(Name = "Article")]
        [Required(ErrorMessage = "{0} is required ")]
        public string Article { get; set; }

        [Display(Name = "Published date")]
        [Required(ErrorMessage = "{0} is required ")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Posted by")]
        // [Required(ErrorMessage = "{0} is required ")]
        public string CompanyEmail { get; set; }

        [Display(Name = "Posted by")]
        // [Required(ErrorMessage = "{0} is required ")]
        public string CompanyName { get; set; }

        [Display(Name = "Number of Likes")]
        public int? Likes { get; set; }

        [Display(Name = "Category")]
        public string Genre { get; set; }

        [NotMapped]
        [Display(Name = "Upload file")]
        public IFormFile ImageFile { get; set; }

    }
}
