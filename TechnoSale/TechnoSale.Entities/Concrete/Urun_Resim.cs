using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoSale.Entities.Concrete
{
    class Urun_Resim
    {
        public int resim_id { get; set; }
        public string resim_url { get; set; }
        public int urun_id { get; set; }
    }
}
