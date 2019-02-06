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
        private IKategoriService _kategoriService;

        public AdminController(IUrunService urunService, IKategoriService kategoriService)
        {
            _urunService = urunService;
            _kategoriService = kategoriService;
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
            var model = new UrunAddViewModel
            {
                Urun = new Urun(),
                Kategoriler = _kategoriService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Urun urun)
        {
            if (ModelState.IsValid)
            {
                _urunService.Add(urun);
                TempData.Add("message","Ürününüz Başarıyla Eklendi");
            }

            return RedirectToAction("Add");
        }

        public ActionResult Update(int urun_id)
        {
            var model = new UrunUpdateViewModel
            {
                Urun = _urunService.GetById(urun_id),
                Kategoriler = _kategoriService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Urun urun)
        {
            if (ModelState.IsValid)
            {
                _urunService.Update(urun);
                TempData.Add("message", "Ürününüz Başarıyla Güncellendi");
            }

            return RedirectToAction("Update");
        }
    }
}
