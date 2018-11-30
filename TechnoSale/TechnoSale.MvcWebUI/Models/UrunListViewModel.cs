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
    }
}
