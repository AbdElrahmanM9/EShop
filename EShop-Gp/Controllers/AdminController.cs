using EShop_Gp.Data;
using EShop_Gp.General;
using EShop_Gp.Models;
using EShop_Gp.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EShop_Gp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public AdminController(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public ActionResult Index(string filter)
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);

            var viewmodel = new PopUp()
            {
                products = _Context.Products.Include(p => p.category).Where(s => s.category.Name.Contains(filter) || filter == null).ToList(),
                carts = _Context.Cart.Include(c => c.Product).ToList()
            };
            return View(viewmodel);
        }
        public ActionResult MoreDetials(string NameEn)
        {
            var prod = _Context.Products.Where(x => x.NameEn == NameEn).FirstOrDefault();

            if (prod != null && prod.Id != 0)
            {
                var Model = new ItemsList()
                {
                    Items = _Context.Items.Where(X => X.ProductId == prod.Id && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
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
        [HttpGet]
        public ActionResult AddNewItems()
        {
            ViewBag.ProductsId = _Context.Products.Select(x => new SelectListItem()
            {
                Text = x.NameAr + "_" + x.NameEn ,
                Value = x.Id.ToString(),
            });
            return View();
        }
        [HttpPost]
        public ActionResult AddNewItems(Product newproduct, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                newproduct.Image = UploadImagesHelper.UploadImage(upload, "Images");

                _Context.Products.Add(newproduct);
                _Context.SaveChanges();
                return RedirectToAction("Home");
            }

            ViewBag.ProductsId = _Context.Categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            return View(newproduct);

        }
        [HttpGet]
        public ActionResult AddNewProduct()
        {
            ViewBag.Categoryid = _Context.Categories.Select(x=> new SelectListItem() { 
                Text= x.Name,
                Value = x.Id.ToString(),
            });
            return View();
        }
        [HttpPost]
        public ActionResult AddNewProduct(Product newproduct, IFormFile upload)
        {
            if (ModelState.IsValid)
            {
                newproduct.Image = UploadImagesHelper.UploadImage(upload, "Image");

                _Context.Products.Add(newproduct);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categoryid = _Context.Categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            return View(newproduct);

        }

        public ActionResult SupplierRequests() 
        {
            var Model = new ItemsList()
            {
                Items = _Context.Items.Where(X => X.FlagRequest == false && X.IsActive == true && X.IsDeleted == false).ToList(),
            };
            return View(Model);
        }
        public ActionResult SaveRequest(Items Items, IFormFile upload)
        {
            if (Items != null)
            {
                try
                {
                    Items = _Context.Items.FirstOrDefault(X => X.Id == Items.Id);
                    Items.Image = UploadImagesHelper.UploadImage(upload, "Image");

                    Items.IsActive = true;
                    Items.IsDeleted = false;
                    Items.FlagRequest = true;
    
                    _Context.Entry(Items).CurrentValues.SetValues(Items);
                    _Context.SaveChanges();
                    var Model = new ItemsList()
                    {
                        Items = _Context.Items.Where(X => X.FlagRequest == false && X.IsActive == true && X.IsDeleted == false).ToList(),
                    };
                    return PartialView("Index", Model);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            return PartialView("Index");
        }
        public ActionResult DeleteRequest(int Id, Items Items, IFormFile upload)
        {
            if (Items != null)
            {
                Items = _Context.Items.FirstOrDefault(X => X.Id == Items.Id);
                Items.Image = UploadImagesHelper.UploadImage(upload, "Image");

                Items.IsActive = false;
                Items.IsDeleted = true;
                Items.FlagRequest = false;

                _Context.Entry(Items).CurrentValues.SetValues(Items);
                _Context.SaveChanges();
                var Model = new ItemsList()
                {
                    Items = _Context.Items.Where(X => X.FlagRequest == false && X.IsActive == true && X.IsDeleted == false).ToList(),
                };
                return PartialView("Index", Model);
            }
            _Context.SaveChanges();
            return RedirectToAction("Home");
        }
        public JsonResult SaveAddress(UserDataViewModel UserDataV)
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN).Id;
            if (UserId != null)
            {
                UserData Userdata = new UserData();
                Userdata.FullName = UserDataV.FullName;
                Userdata.PhoneNumber = UserDataV.PhoneNumber;
                Userdata.Street = UserDataV.Street;
                Userdata.BuildingNameOrNum = UserDataV.BuildingNameOrNum;
                Userdata.CityAndArea = UserDataV.CityAndArea;
                Userdata.NearestToken = UserDataV.NearestToken;
                Userdata.UserId = UserId;

                _Context.UserData.Add(Userdata);
                _Context.SaveChanges();
                return Json("Done");
            }
            else
            {
                return Json("Error");
            }
        }


        #region bla7
        //public ActionResult MoreDetials(int Id, string filter)
        //{
        //    var prod = _Context.Products.Where(x => x.NameEn == filter).FirstOrDefault();

        //    if (Id == 2)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == prod.Id && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return PartialView("_AllItems");
        //    }
        //    else if (Id == 3)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == 2 && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return RedirectToAction("_Laptops", "Home");
        //    }
        //    else if (Id == 4)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == 2 && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return RedirectToAction("_Phones", "Home");
        //    }
        //    else if (Id == 5)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == 2 && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return RedirectToAction("_Cookers", "Home");
        //    }
        //    else if (Id == 6)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == 2 && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return RedirectToAction("_WashingMachines", "Home");
        //    }
        //    else if (Id == 6)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == 2 && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return RedirectToAction("_Refrigerators", "Home");
        //    }
        //    else if (Id == 7)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == 2 && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return RedirectToAction("_Heaters", "Home");

        //    }
        //    else if (Id == 8)
        //    {
        //        var Model = new ItemsList()
        //        {
        //            Items = _Context.Items.Where(X => X.ProductId == 2 && X.FlagRequest == true && X.IsDeleted == false && X.IsActive == true && X.sold == false).ToList(),
        //        };
        //        return RedirectToAction("_Accessories", "Home");
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        #endregion
    }
}
