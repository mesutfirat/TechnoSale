﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Kampanya:IEntity
    {
        [Key]
        public int kampanya_id { get; set; }
        public decimal kampanya_fiyat { get; set; }
        public DateTime kampanya_baslangic { get; set; }
        public DateTime kampanya_bitis { get; set; }
        public int urun_id { get; set; }
    }
}
