using EShop_Gp.Data;
using EShop_Gp.General;
using EShop_Gp.Models;
using EShop_Gp.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public SupplierController(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            var viewmodel = new PopUp()
            {
                products = _Context.Products.Include(p => p.category).ToList(),
                carts = _Context.Cart.Include(c => c.Product).Include(x => x.Items).ToList()
            };
            return View(viewmodel);
        }
        [HttpGet]
        public ActionResult AddNewItems()
        {
            ViewBag.ProductsId = _Context.Products.Select(x => new SelectListItem()
            {
                Text = x.NameAr + "_" + x.NameEn,
                Value = x.Id.ToString(),
            });
            return View();
        }
        [HttpPost]
        public ActionResult AddNewItems(Items newItems, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                newItems.Image = UploadImagesHelper.UploadImage(upload, "Images");

                newItems.IsActive = true;
                newItems.IsDeleted = false;
                newItems.FlagRequest = false;
                _Context.Items.Add(newItems);
                _Context.SaveChanges();
                return Json(newItems);
            }

            ViewBag.ProductsId = _Context.Products.Select(x => new SelectListItem()
            {
                Text = x.NameAr + "_" + x.NameEn,
                Value = x.Id.ToString(),
            });
            
            return View(newItems);
        }
    }
}
