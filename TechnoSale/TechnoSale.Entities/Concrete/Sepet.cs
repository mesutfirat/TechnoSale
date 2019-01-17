using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Sepet : IEntity
    {
        public Sepet()
        {
            //CartLines = new List<CartLine>();
            this.sepet_urun = new List<sepet_urun>();
        }
        
        [Key]
        public int sepet_id { get; set; }
        public decimal toplam_odeme {

            /*get { return CartLines.Sum(c => c.Urun.urun_fiyat * c.urun_adet); } */
            get; set;
        }
        public int user_id { get; set; }
        public virtual ICollection<sepet_urun> sepet_urun { get; set; }
        //public List<CartLine> CartLines { get; set; }
    }
}
