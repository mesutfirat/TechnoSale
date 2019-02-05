using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Business.Abstract;
using TechnoSale.Entities.Concrete;
using TechnoSale.MvcWebUI.Models;

namespace TechnoSale.MvcWebUI.Controllers
{
    public class AdminController:Controller
    {
        private IUrunService _urunService;

        public AdminController(IUrunService urunService)
        {
            _urunService = urunService;
        }

        public ActionResult Index()
        {
            var urunListViewModel = new UrunListViewModel
            {
                Urunler = _urunService.GetAll()
            };
            return View(urunListViewModel);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Urun urun)
        {
            if (ModelState.IsValid)
            {
                _urunService.Add(urun);
                TempData.Add("message","Ürününüz Başarıyla Eklendi");
            }

            return View();
        }
    }
}
