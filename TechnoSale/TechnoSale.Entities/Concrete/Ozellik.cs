using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoSale.Entities.Concrete
{
    class Ozellik
    {
        public Ozellik()
        {
            this.Urun = new List<Urun>();
            this.Kategori = new List<Kategori>();
        }

        public int ozellik_id { get; set; }
        public string ozellik_adi { get; set; }
        public virtual ICollection<Urun> Urun { get; set; }
        public virtual ICollection<Kategori> Kategori { get; set; }
    }
}
