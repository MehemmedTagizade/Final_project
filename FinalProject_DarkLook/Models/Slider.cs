using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
    }
}
