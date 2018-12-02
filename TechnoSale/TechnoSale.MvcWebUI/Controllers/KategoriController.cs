using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Business.Abstract;
using TechnoSale.MvcWebUI.Models;

namespace TechnoSale.MvcWebUI.Controllers
{
    public class KategoriController: Controller
    {
        private IKategoriService _kategoriService;

        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        public ActionResult Index()
        {
            var kategori = _kategoriService.GetAll();
            KategoriListViewModel model = new KategoriListViewModel
            {
                Kategoriler = kategori

            };

            return View(model);
        }
    }
}
