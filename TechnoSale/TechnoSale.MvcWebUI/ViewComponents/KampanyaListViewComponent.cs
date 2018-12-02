using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Business.Abstract;
using TechnoSale.MvcWebUI.Models;

namespace TechnoSale.MvcWebUI.ViewComponents
{
    public class KampanyaListViewComponent:ViewComponent
    {
        private IKampanyaService _kampanyaService;

        public KampanyaListViewComponent(IKampanyaService kampanyaService)
        {
            _kampanyaService = kampanyaService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new KampanyaListViewModel()
            {
                Kampanyalar = _kampanyaService.GetAll()
            };
        return View(model);
        }
    }
}
