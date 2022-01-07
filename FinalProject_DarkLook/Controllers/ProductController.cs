using FinalProject_DarkLook.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext Context)
        {
            _context = Context;
        }

        public IActionResult Index()
        {
            return View();
        }


        //public async Task<IActionResult> GetDetail(int? Id)
        //{

        //}
    }
}
