using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.MvcWebUI.Models
{
    public class UrunListViewModel
    {
        public List<Urun> Urunler { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentKategori { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
