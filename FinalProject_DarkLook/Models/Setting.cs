using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.Models
{
    public class Setting
    {

        public int Id { get; set; }
        [StringLength(50)]

        public string Logo { get; set; }
        [StringLength(200)]
        public string WorkTimeDesc {get;set;}
        [StringLength(200)]

        public string FacebookUrl { get; set; }
        [StringLength(200)]

        public string GoogleUrl { get; set; }
        [StringLength(200)]

        public string LinkUrl { get; set; }
        [StringLength(200)]

        public string Twitter { get; set; }
        [StringLength(200)]

        public string LastUrl { get; set; }
        [StringLength(200)]


        public string Adress { get; set; }
        [StringLength(200)]

        public string Street { get; set; }
        [StringLength(50)]

        public string Number { get; set; }
        [StringLength(100)]

        public string Email { get; set; }
        [StringLength(200)]

        public string WebUrl { get; set; }
    }
}
