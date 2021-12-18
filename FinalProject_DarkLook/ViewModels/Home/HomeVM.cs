using FinalProject_DarkLook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.ViewModels.Home
{
    public class HomeVM
    {
        public ICollection<Slider>  Sliders { get; set; }
        public ICollection<Future> Futures { get; set; }

    }
}
