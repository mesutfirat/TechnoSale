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
    public class KategoriListViewComponent:ViewComponent
    {
        private IKategoriService _kategoriService;

        public KategoriListViewComponent(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new KategoriListViewModel()
            {
                Kategoriler = _kategoriService.GetAll()
            };
            return View(model);
        }
    }
}
