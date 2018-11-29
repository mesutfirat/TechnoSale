using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Business.Abstract;
using TechnoSale.MvcWebUI.Models;

namespace TechnoSale.MvcWebUI.Controllers
{
    public class KampanyaController: Controller
    {
        private IKampanyaService _kampanyaService;

        public KampanyaController(IKampanyaService urunService)
        {
            _kampanyaService = urunService;
        }
        public ActionResult Index()
        {
            var kampanya = _kampanyaService.GetAll();
            KampanyaListViewModel model = new KampanyaListViewModel
            {
                Kampanyas = kampanya

            };

            return View(model);
        }
    }
}
