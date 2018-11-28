using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoSale.Entities.Concrete
{
    class Kategori
    {
        public Kategori()
        {
            this.Urun = new List<Urun>();
            this.Ozellik = new List<Ozellik>();
        }

        public int kategori_id { get; set; }
        public string kategori_adi { get; set; }
        public int ust_kategori_id { get; set; }

        public virtual ICollection<Urun> Urun { get; set; }
        public virtual ICollection<Ozellik> Ozellik { get; set; }
    }
}
