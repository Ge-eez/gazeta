using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GazetaCompanies.Models
{
    public class FileUpload
    {
        public IFormFile file { get; set; }
        public string News { get; set; }
    }
}