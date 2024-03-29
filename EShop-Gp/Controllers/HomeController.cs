﻿using EShop_Gp.Data;
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
using System.Transactions;

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
            ItemsList ItemList = new ItemsList();

            ItemList.Item = _Context.Items.FirstOrDefault(c => c.Id == id);
            ItemList.Items = _Context.Items.Where(x => x.ProductId == ItemList.Item.ProductId).Take(7).ToList();

            var Products = _Context.Items.FirstOrDefault(c => c.Id == id);

            if (ItemList.Item == null)
            {
                return NotFound();
            }
            int Count = 1;
            //var Itemid = _Context.Items.FirstOrDefault(c => c.ProductId == Id);
            //var Pro = _Context.Items.Where(x => x.ProductId == id).Take(7).ToList();
            Slid Slid = new Slid();

            foreach (var item in ItemList.Items)
            {
                if (Count == 1)
                {
                    Slid.Name1 = item.NameAr;
                    Slid.Img1 = item.Image;
                    Slid.Price1 = item.Price;
                }
                if (Count == 2)
                {
                    Slid.Name2 = item.NameAr;
                    Slid.Img2 = item.Image;
                    Slid.Price2 = item.Price;
                }
                if (Count == 3)
                {
                    Slid.Name3 = item.NameAr;
                    Slid.Img3 = item.Image;
                    Slid.Price3 = item.Price;
                }
                if (Count == 4)
                {
                    Slid.Name4 = item.NameAr;
                    Slid.Img4 = item.Image;
                    Slid.Price4 = item.Price;
                }
                if (Count == 5)
                {
                    Slid.Name5 = item.NameAr;
                    Slid.Img5 = item.Image;
                    Slid.Price5 = item.Price;
                }
                if (Count == 6)
                {
                    Slid.Name6 = item.NameAr;
                    Slid.Img6 = item.Image;
                    Slid.Price6 = item.Price;
                }
                if (Count == 7)
                {
                    Slid.Name7 = item.NameAr;
                    Slid.Img7 = item.Image;
                    Slid.Price7 = item.Price;
                }
                Count++;
            }
            Slid.ProductId = ItemList.Item.ProductId;
            ItemList.Slid = Slid;

            return PartialView(ItemList);
        }
        public ActionResult _slid(int? Id)
        {
            if (Id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            Slid Slid = new Slid();
            //var Itemid = _Context.Items.FirstOrDefault(c => c.ProductId == Id);
            var Pro = _Context.Items.Where(x => x.ProductId == Id).Take(7).ToList();
            Slid.ProductId = Id.Value;
            return PartialView(Slid);
        }
        public ActionResult AddToCart(int id, int ProductId)
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
                    Items = _Context.Items.Where(x => x.IsActive == true && x.IsDeleted == false).ToList(),
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
                Items = Items.Where(s => s.NameAr.Contains(searchString) || s.NameEn.Contains(searchString) || s.Description.Contains(searchString));
            }

            var ItemsModel = new ItemsList
            {
                Items = await Items.ToListAsync()
            };

            return PartialView("_AllItems", ItemsModel);
        }

        #region bla7
        public ActionResult TransactionScope(int id, int ProductId)
        {
            using (var tran = new TransactionScope(TransactionScopeOption.RequiresNew,new TransactionOptions { 
                IsolationLevel=IsolationLevel.ReadCommitted
            }))
            {
                try
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
                            Items = _Context.Items.Where(x => x.IsActive == true && x.IsDeleted == false).ToList(),
                        };
                        tran.Complete();
                        return PartialView("_AllItems", ItemsModel);
                    }
                    else
                    {
                        return RedirectToAction("_LoginToContinueCart", "Cart");
                    }
                }
                catch (Exception e)
                {
                    tran.Dispose();
                    throw;
                }

            }
        }
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
