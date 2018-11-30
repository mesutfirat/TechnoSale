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
        public ActionResult Index()
        {
            var urun = _urunService.GetAll();
            UrunListViewModel model = new UrunListViewModel
            {
                Urunler = urun

            };

            return View(model);
        }
    }
}
