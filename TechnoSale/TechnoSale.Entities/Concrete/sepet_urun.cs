using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;

namespace TechnoSale.Entities.Concrete
{
    public class sepet_urun : IEntity
    {
        public int sepet_id { get; set; }
        public int urun_id { get; set; }
        public int urun_adet { get; set; }
        public decimal urun_fiyat { get; set; }
    }
}
