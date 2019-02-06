using System.Collections.Generic;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.MvcWebUI.Models
{
    public class UrunUpdateViewModel
    {
        public Urun Urun { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}