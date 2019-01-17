using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechnoSale.Core.Entities;

namespace TechnoSale.Entities.Concrete
{
    public class CartLine
    {
        
        public Urun Urun { get; set; }
        public int urun_adet { get; set; }
    }
}
