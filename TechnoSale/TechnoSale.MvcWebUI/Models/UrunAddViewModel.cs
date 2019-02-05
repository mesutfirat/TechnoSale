using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.MvcWebUI.Models
{
    public class UrunAddViewModel
    {
        public Urun Urun { get; set; }
    }
}
