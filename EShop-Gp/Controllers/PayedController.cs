﻿using EShop_Gp.Data;
using EShop_Gp.Models;
using EShop_Gp.ViewModel;
using EShop_Gp.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace EShop_Gp.Controllers
{
    public class PayedController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public PayedController(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult _Address()
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN).Id;
            if (UserId != null)
            {
                var UserDetail = _Context.UserData.FirstOrDefault(x => x.UserId == UserId);
                UserDataViewModel UserDataViewModel = new UserDataViewModel();

                if (UserDetail != null)
                {
                    UserDataViewModel.FullName = UserDetail.FullName;
                    UserDataViewModel.BuildingNameOrNum = UserDetail.BuildingNameOrNum;
                    UserDataViewModel.CityAndArea = UserDetail.CityAndArea;
                    UserDataViewModel.NearestToken = UserDetail.NearestToken;
                    UserDataViewModel.PhoneNumber = UserDetail.PhoneNumber;
                    UserDataViewModel.Street = UserDetail.Street;
                 
                    return PartialView(UserDataViewModel);
                }
                else
                {
                    return PartialView(UserDataViewModel);
                }
            }
            else
            {
                return null;
            }
        }
        public IActionResult _Payment()
        {
            return PartialView();
        }
        public IActionResult _GoodsAndShipping()
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);
            if (UserId != null)
            {
                var viewmodel = new PopUp()
                {
                    carts = _Context.Cart.Include(c => c.Product).Include(c => c.Items).Where(x => x.UserId == UserId.Id && x.IsDeleted == false && x.IsPaid == false).ToList(),
                };
                viewmodel.SumPrice = viewmodel.carts.Select(s => s.Items.Price).Sum();
                viewmodel.Items = _Context.Items.Where(x => x.ProductId == viewmodel.carts.FirstOrDefault().ProductId).Take(3).ToList();
                viewmodel.DayOfReceipt = DateTime.Now.AddDays(5).ToString("yyyy/MM/dd");
                viewmodel.CartIds = viewmodel.carts.Select(x => x.Id).ToList();

                return PartialView(viewmodel);
            }
            else
            {
                var viewmodel = new PopUp()
                {
                    carts = _Context.Cart.Include(c => c.Product).Include(c => c.Items).ToList(),
                };
                var cart = _Context.Items.Where(x => x.AddToCart > 0);
                return PartialView("_LoginToContinueCart", viewmodel);
            }
        }
        public ActionResult AddToCard(string CardNumber, string ExpirationDate, string NameOnTheCard)
        {
            var PayedByVisa = _Context.UserPayment.Where(x => x.CardNumber == CardNumber && x.ExpirationDate == ExpirationDate && x.NameOnTheCard == NameOnTheCard && x.IsVisa == true).FirstOrDefault();
            if (PayedByVisa != null)
            {
                var UserN = User.Identity.Name;
                var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);
                var Data = _Context.UserData.Where(x => x.UserId == UserId.Id).FirstOrDefault();

                Data.IsCreditCard = true;
                _Context.Entry(Data).CurrentValues.SetValues(Data);
                _Context.SaveChanges();

                return PartialView("_Payment");
            }
            else
            {
                return Json("Error");
            }
        }

        [HttpPost]
        public JsonResult SaveAddress(UserDataViewModel UserDataV)
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN).Id;
            if (UserId != null)
            {
                var Cart = _Context.Cart.Where(x => x.UserId == UserId).FirstOrDefault();
                var UserDetail = _Context.UserData.FirstOrDefault(x => x.UserId == UserId && x.FullName == UserDataV.FullName && x.PhoneNumber == UserDataV.PhoneNumber && x.Street == UserDataV.Street && x.BuildingNameOrNum == UserDataV.BuildingNameOrNum && x.CityAndArea == UserDataV.CityAndArea && x.NearestToken == UserDataV.NearestToken);

                if (UserDetail != null)
                {
                    return Json("Done");
                }
                else
                {
                    UserData Userdata = new UserData();
                    Userdata.FullName = UserDataV.FullName;
                    Userdata.PhoneNumber = UserDataV.PhoneNumber;
                    Userdata.Street = UserDataV.Street;
                    Userdata.BuildingNameOrNum = UserDataV.BuildingNameOrNum;
                    Userdata.CityAndArea = UserDataV.CityAndArea;
                    Userdata.NearestToken = UserDataV.NearestToken;
                    Userdata.UserId = UserId;
                    Userdata.CartId = Cart.Id;

                    _Context.UserData.Add(Userdata);
                    _Context.SaveChanges();
                    return Json("Done");
                }
            }
            else
            {
                return Json("Error");
            }
        }

        public ActionResult FinallyPaid(bool Cash)
        {
            if (Cash == true)
            {
                var UserN = User.Identity.Name;
                var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);
                var Data = _Context.UserData.Where(x => x.UserId == UserId.Id).FirstOrDefault();

                Data.IsCash = true;

                _Context.Entry(Data).CurrentValues.SetValues(Data);
                _Context.SaveChanges();
                return Json("CashDone");
            }
            else
            {
                var UserN = User.Identity.Name;
                var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);
                var Data = _Context.UserData.Where(x => x.UserId == UserId.Id).FirstOrDefault();
                if (Data.IsCreditCard == true)
                {
                    return Json("CreditDone");
                }
                else
                {
                    return Json("ChoosePaymentMethod");
                }
            }
        }
        public ActionResult ConfirmOrder(int CartMasterId)
        {
            try
            {
                var CartMaster = _Context.CartMaster.FirstOrDefault(x => x.Id == CartMasterId);
                CartMaster.IsPaid = true;

                _Context.Entry(CartMaster).CurrentValues.SetValues(CartMaster);
                _Context.SaveChanges();
                var CartDetail = _Context.Cart.Where(x => x.CartMasterId == CartMaster.Id).ToList();

                foreach (var item in CartDetail)
                {
                    var CartModel = _Context.Cart.FirstOrDefault(x => x.Id == item.Id);
                    CartModel.IsPaid = true;

                    _Context.Entry(CartModel).CurrentValues.SetValues(CartModel);
                }
                _Context.SaveChanges();

                return RedirectToAction("Index","Home");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
