﻿using FinalProject_DarkLook.DAL;
using FinalProject_DarkLook.Models;
using FinalProject_DarkLook.ViewModels;
using FinalProject_DarkLook.ViewModels.Home;
using FinalProject_DarkLook.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_DarkLook.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
            {

                return View(new ProductVM
                {
                    WatchCards = await _context.WatchCards.Include(x=>x.watchColours).Include(x=>x.watchSizes).Where(x => x.IsDeleted == false).ToListAsync(),
                    BrandLogos=await _context.BrandLogos.Where(x=>x.IsDeleted==false).ToListAsync()

                });
            }

        public async Task<IActionResult> WatchDetail (int? Id)
        {
            WatchCard watchCard = await _context.WatchCards.Where(x => x.IsDeleted == false).Include(x => x.watchColours).ThenInclude(x=>x.Colour).Include(x => x.watchSizes).ThenInclude(x=>x.Size).FirstOrDefaultAsync(x => x.Id == Id);

            List<string> Sizes = new List<string>();
            List<string> Colours = new List<string>();

            foreach(var WatchSize in watchCard.watchSizes)
            {
                Sizes.Add(WatchSize.Size.Sizes);
            }

            ProductVM productVM = new ProductVM
            {
                Watchard = watchCard,
                Sizess=Sizes


            };
            return View(productVM);


        }
    }
}
