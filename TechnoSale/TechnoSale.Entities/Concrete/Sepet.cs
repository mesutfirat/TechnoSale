using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;

namespace TechnoSale.Entities.Concrete
{
    public class Sepet : IEntity
    {
        public Sepet()
        {
            this.Urun = new List<Urun>();
        }


        public int sepet_id { get; set; }
        public decimal toplam_odeme { get; set; }
        public int user_id { get; set; }
        public virtual ICollection<Urun> Urun { get; set; }
    }
}
