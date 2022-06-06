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
            var UserN = User.Identity.Name;
            var UserId = _Context.User.FirstOrDefault(x => x.UserName == UserN);

            if (UserId.Type == "Admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (UserId.Type == "Supplier")
            {
                var viewmodel = new PopUp()
                {
                    products = _Context.Products.Include(p => p.category).ToList(),
                    carts = _Context.Cart.Include(c => c.Product).Include(x => x.Items).ToList()
                };
                return View(viewmodel);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
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
        public ActionResult AddNewItems([FromForm] ItemsModel newproduct)
        {
            if (ModelState.IsValid)
            {
                var UserN = User.Identity.Name;
                var UserId = _Context.User.FirstOrDefault(x => x.UserName == UserN);

                var product = new Items()
                {
                    NameAr = newproduct.NameAr,
                    NameEn = newproduct.NameEn,
                    Price = newproduct.Price.Value,
                    PriceCost = newproduct.PriceCost.Value,
                    Description = newproduct.Description,
                    ProductId = newproduct.ProductId.Value,
                    IsActive = true,
                    FlagRequest = false,
                    IsDeleted = false,
                    UserId = UserId.Id
                };
                if (newproduct.Image != null)
                {
                    product.Image = UploadImagesHelper.UploadImage(newproduct.Image, "Images");
                }
                _Context.Items.Add(product);
                _Context.SaveChanges();
                return Json("Done");
            }

            ViewBag.ProductsId = _Context.Categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            return View(newproduct);
        }
        
        public ActionResult MyProductApproval()
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.User.FirstOrDefault(x => x.UserName == UserN);

            var viewmodel = new PopUp()
            {
                Items = _Context.Items.Include(p => p.Product).Where(x=>x.UserId == UserId.Id && x.FlagRequest == true).ToList(),
            };
            return View(viewmodel);
        }
    }
}
