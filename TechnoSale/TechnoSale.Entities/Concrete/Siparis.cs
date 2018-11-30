using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Siparis : IEntity
    {
        public Siparis()
        {
            this.siparis_urun = new List<siparis_urun>();
        }

        [Key]
        public int siparis_id { get; set; }
        public DateTime siparis_tarih { get; set; }
        public Boolean siparis_durum { get; set; }
        public decimal toplam_odeme { get; set; }
        public int user_id { get; set; }
        public virtual ICollection<siparis_urun> siparis_urun { get; set; }
    }
}
