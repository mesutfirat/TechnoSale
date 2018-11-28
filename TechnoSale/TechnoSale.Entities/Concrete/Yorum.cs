using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoSale.Entities.Concrete
{
    class Yorum
    {
        public int yorum_id { get; set; }
        public string yorum_icerik { get; set; }
        public DateTime yorum_tarih { get; set; }
        public int urun_id { get; set; }
        public int user_id { get; set; }
    }
}
