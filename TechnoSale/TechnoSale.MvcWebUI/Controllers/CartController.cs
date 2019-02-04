using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Business.Abstract;
using TechnoSale.Entities.Concrete;
using TechnoSale.MvcWebUI.Models;
using TechnoSale.MvcWebUI.Services;

namespace TechnoSale.MvcWebUI.Controllers
{
    public class CartController:Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IUrunService _urunService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IUrunService urunService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _urunService = urunService;
        } 

        public ActionResult AddToCart(int urun_id)
        {
            var urunToBeAdded = _urunService.GetById(urun_id); 
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCard(cart, urunToBeAdded);
            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Ürününüz, {0}, başarıyla sepete eklendi!",urunToBeAdded.urun_adi));

           return RedirectToAction("Index", "Urun");
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int urun_id)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCard(cart,urun_id);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Ürününüz başarıyla sepetten kaldırıldı!!"));
            return RedirectToAction("List");
        }

        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message",String.Format("Teşekkürler {0} {1}, Siparişiniz hazırlanıyor...",shippingDetails.FirstName,shippingDetails.LastName));
            return View();
        }
    }
}
