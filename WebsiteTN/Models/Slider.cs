using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteTN.Models
{
    public class Slider
    {
        [Key]
        public int SlideId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Thumb { get; set; }
        public int? Orders { get; set; }
        public string Position { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool Active { get; set; }
    }
}
