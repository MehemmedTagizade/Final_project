using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.Models
{
    public class WatchCard
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Image { get; set; }
        [StringLength(200)]

        public string HoverImage { get; set; }
        [Required, StringLength(150)]

        public string Desc { get; set; }
        [Required]
        public double Price { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNewArrivals { get; set; }
        public bool IsBestSeller{ get; set; }
        public bool IsFeatured { get; set; }
        public bool IsDealsOftheWeek{ get; set; }


    }
}
