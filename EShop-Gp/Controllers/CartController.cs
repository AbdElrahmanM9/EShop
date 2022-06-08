using EShop_Gp.Data;
using EShop_Gp.Models;
using EShop_Gp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public CartController(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult _Cart()
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);
            if (UserId != null)
            {
                var viewmodel = new PopUp()
                {
                    carts = _Context.Cart.Where(x => x.UserId == UserId.Id && x.IsDeleted == false && x.IsPaid == false).Include(c => c.Product).Include(c => c.Items).Where(x => x.UserId == UserId.Id).ToList(),
                };
                viewmodel.SumPrice = viewmodel.carts.Select(s => s.Items.Price).Sum();
                if (viewmodel.carts != null && viewmodel.carts.Count() != 0)
                {
                    viewmodel.Items = _Context.Items.Where(x => x.ProductId == viewmodel.carts.FirstOrDefault().ProductId).Take(3).ToList();
                }

                return PartialView(viewmodel);
            }
            else
            {
                return PartialView("_LoginToContinueCart");
            }
        }
        public ActionResult _LoginToContinueCart()
        {
            return View();
        }
        public ActionResult DeleteDiscarding(int Id)
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN);
            var Cart = _Context.Cart.FirstOrDefault(x => x.ItemsId == Id && x.UserId == UserId.Id);
            Cart.IsDeleted = true;
            Cart.IsActive = false;

            _Context.SaveChanges();

            return RedirectToAction("_Cart");
        }
        public ActionResult _StatusOrder()
        {
            var UserN = User.Identity.Name;
            var UserId = _Context.Users.FirstOrDefault(x => x.UserName == UserN).Id;
            if (UserId != null)
            {
                List<StatusOrderViewModel> StatusOrderViewModelList = new List<StatusOrderViewModel>();

                var CartMaster = _Context.CartMaster.FirstOrDefault(x => x.UserId == UserId);
                if (CartMaster != null)
                {
                    var Cart = _Context.Cart.Include(x => x.Items).Where(s => s.CartMasterId == CartMaster.Id);
                    foreach (var item in Cart)
                    {
                        StatusOrderViewModel StatusOrderViewModel = new StatusOrderViewModel();

                        StatusOrderViewModel.Image = item.Items.Image;
                        StatusOrderViewModel.ItemId = item.ItemsId;
                        StatusOrderViewModel.NameAr = item.Items.NameAr;
                        StatusOrderViewModel.NameEn = item.Items.NameEn;
                        StatusOrderViewModel.Price = item.Items.Price;
                        StatusOrderViewModel.OrderTimeOfReceipt = CartMaster.OrderTime.AddDays(5).ToString("yyyy/MM/dd");
                        StatusOrderViewModelList.Add(StatusOrderViewModel);
                    }
                    return PartialView(StatusOrderViewModelList);
                }
                else
                {
                    return PartialView();
                }
            }
            else
            {
                return PartialView();
            }
        }
    }
}
