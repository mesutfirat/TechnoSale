using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoSale.Entities.Concrete
{
    class siparis_urun
    {
        public int siparis_id { get; set; }
        public int urun_id { get; set; }
        public int urun_adet { get; set; }
        public decimal urun_fiyat { get; set; }
    }
}
