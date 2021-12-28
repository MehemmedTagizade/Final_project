using FinalProject_DarkLook.DAL;
using FinalProject_DarkLook.ViewModels.Contacs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(new ContactVM
            {

                Categories = await _context.Categories.Where(x => x.IsDeleted == false).ToListAsync(),
                contact=await _context.Contacts.FirstOrDefaultAsync(x=>x.IsDelete==false)


            }); ;
        }
    }
}
