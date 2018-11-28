﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoSale.Entities.Concrete
{
    class Siparis
    {
        public Siparis()
        {
            this.Urun = new List<Urun>();
        }

        public int siparis_id { get; set; }
        public DateTime siparis_tarih { get; set; }
        public Boolean siparis_durum { get; set; }
        public decimal toplam_odeme { get; set; }
        public int user_id { get; set; }
        public virtual ICollection<Urun> Urun { get; set; }
    }
}
