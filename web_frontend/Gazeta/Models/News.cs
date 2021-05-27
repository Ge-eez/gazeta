using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Image { get; set; }
        public string Article { get; set; }
        public string Company { get; set; }
        public DateTime PublishDate { get; set; }
        public int Likes { get; set; }
    }
}
