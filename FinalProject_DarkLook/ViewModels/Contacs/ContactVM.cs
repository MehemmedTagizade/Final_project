using FinalProject_DarkLook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.ViewModels.Contacs
{
    public class ContactVM
    {
        public Contact contact { get; set; }
        public ICollection<Category>  Categories {get;set;}
    }
}
