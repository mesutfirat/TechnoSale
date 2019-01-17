using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Business.Abstract;
using TechnoSale.MvcWebUI.Models;

namespace TechnoSale.MvcWebUI.Controllers
{
    public class UrunController: Controller
    {
        private IUrunService _urunService;

        public UrunController(IUrunService urunService)
        {
            _urunService = urunService;
        }
        public ActionResult Index(int page=1, int kategori=0)
        {
            int pageSize = 5;
            var urun = _urunService.GetByKategori(kategori);
            UrunListViewModel model = new UrunListViewModel
            {
                Urunler = urun.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(urun.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentKategori = kategori,
                CurrentPage = page
            };
            return View(model);
        }

        //public string Session()
        //{
        //    HttpContext.Session.SetString("city", "Ankara");
        //    HttpContext.Session.SetInt32("age", 32);

        //    HttpContext.Session.GetString("city");
        //    HttpContext.Session.GetInt32("age");
        //}
         
    }
}
