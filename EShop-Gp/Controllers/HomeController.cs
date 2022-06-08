using EShop_Gp.Data;
using EShop_Gp.Models;
using EShop_Gp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EShop_Gp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _Context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _ContextContext)
        {
            _logger = logger;
            _Context = _ContextContext;
        }

        public IActionResult Index()
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.User.FirstOrDefault(x => x.UserName == UserN);
            if (UserId != null)
            {
                if (UserId.Type == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if (UserId.Type == "Supplier")
                {
                    return RedirectToAction("Index", "Supplier");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult MoreDetials(string NameEn)
        {
            var prod = _Context.Products.Where(x => x.NameEn == NameEn).FirstOrDefault();

            if (prod != null && prod.Id != 0)
            {
                var Model = new ItemsList()
                {
                    Items = _Context.Items.Where(X => X.ProductId == prod.Id && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false && X.AddToCart == 0).ToList(),
                };
                ViewBag.Name = NameEn;

                return PartialView("_AllItems", Model);
            }
            else
            {
                return null;
            }
        }
        public ActionResult _DetialsItem(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            var Products = _Context.Items.FirstOrDefault(c => c.Id == id);
            if (Products == null)
            {
                return NotFound();
            }
            return PartialView(Products);
        }
        public ActionResult AddToCart(int id,int ProductId)
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);
            if (UserId != null)
            {
                var Item = _Context.Items.FirstOrDefault(x => x.Id == id);

                Item.AddToCart = Item.AddToCart + 1;
                var Cartmaster = _Context.CartMaster.Where(x => x.UserId == UserId.Id && x.IsPaid == false).FirstOrDefault();
                CartMaster CartMaster = new CartMaster();
                Cart Cart = new Cart();

                if (Cartmaster == null)
                {
                    CartMaster.IsActive = true;
                    CartMaster.IsDeleted = false;
                    CartMaster.OrderTime = DateTime.Now;
                    CartMaster.UserId = UserId.Id;

                    _Context.CartMaster.Add(CartMaster);
                    _Context.SaveChanges();

                    Cart.ProductId = ProductId;
                    Cart.ItemsId = id;
                    Cart.UserId = UserId.Id;
                    Cart.AddedTime = DateTime.Now;
                    Cart.CartMasterId = CartMaster.Id;

                    _Context.Cart.Add(Cart);
                    _Context.SaveChanges();
                }
                else
                {
                    Cart.ProductId = ProductId;
                    Cart.ItemsId = id;
                    Cart.UserId = UserId.Id;
                    Cart.AddedTime = DateTime.Now;
                    Cart.CartMasterId = Cartmaster.Id;

                    _Context.Cart.Add(Cart);
                    _Context.SaveChanges();
                }


                var ItemsModel = new ItemsList
                {
                    Items = _Context.Items.Where(x=>x.IsActive == true && x.IsDeleted == false).ToList(),
                };

                return PartialView("_AllItems", ItemsModel);
            }
            else
            {
                return RedirectToAction("_LoginToContinueCart", "Cart");
            }
        }

        public async Task<IActionResult> Search(string searchString)
        {
            var Items = from m in _Context.Items
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                Items = Items.Where(s => s.NameAr.Contains(searchString)|| s.NameEn.Contains(searchString)|| s.Description.Contains(searchString));
            }

            var ItemsModel = new ItemsList
            {
                Items = await Items.ToListAsync()
            };

            return PartialView("_AllItems", ItemsModel);
        }

        #region bla7
        //public ActionResult _Tvs(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "Tvs").FirstOrDefault();
        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(X => X.ProductId == prod.Id && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true).ToList(),
        //    };

        //    return PartialView(Model);
        //}
        //public ActionResult _Refrigerators(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "refrigerators").FirstOrDefault();
        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(Y => Y.ProductId == prod.Id && Y.FlagRequest == true && Y.IsDeleted == false && Y.IsActive == true).ToList(),
        //    };
        //    return PartialView(Model);
        //}

        //public ActionResult _Cookers(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "Cookers").FirstOrDefault();

        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(Y => Y.ProductId == prod.Id && Y.FlagRequest == true && Y.IsDeleted == false && Y.IsActive == true).ToList(),
        //    };
        //    return PartialView(Model);
        //}

        //public ActionResult _Heaters(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "heaters").FirstOrDefault();

        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(Y => Y.ProductId == prod.Id && Y.FlagRequest == true && Y.IsDeleted == false && Y.IsActive == true).ToList(),
        //    };
        //    return PartialView(Model);
        //}


        //public ActionResult _WashingMachines(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "washing machines").FirstOrDefault();
        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(Y => Y.ProductId == prod.Id && Y.FlagRequest == true && Y.IsDeleted == false && Y.IsActive == true).ToList(),
        //    };
        //    return PartialView(Model);
        //}

        //public ActionResult _Laptops(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "Laptops").FirstOrDefault();
        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(Y => Y.ProductId == 2 && Y.FlagRequest == true && Y.IsDeleted == false && Y.IsActive == true).ToList(),
        //    };
        //    return PartialView(Model);
        //}

        //public ActionResult _Accessories(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "Accessories").FirstOrDefault();
        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(Y => Y.ProductId == prod.Id && Y.FlagRequest == true && Y.IsDeleted == false && Y.IsActive == true).ToList(),
        //    };
        //    return PartialView(Model);

        //}
        //public ActionResult _Phones(string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == "Phones").FirstOrDefault();
        //    var Model = new ItemsList()
        //    {
        //        Items = _Context.Items.Where(Y => Y.ProductId == prod.Id && Y.FlagRequest == true && Y.IsDeleted == false && Y.IsActive == true).ToList(),
        //    };
        //    return PartialView(Model);

        //}
        #endregion
    }
}
