using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoSale.Entities.Concrete
{
    class sepet_urun
    {
        public int sepet_id { get; set; }
        public int urun_id { get; set; }
        public int urun_adet { get; set; }
        public decimal urun_fiyat { get; set; }
    }
}
