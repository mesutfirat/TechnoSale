﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class user_rol : IEntity
    {
        [Key]
        public int user_id { get; set; }
        public int rol_id { get; set; }
        public DateTime rol_tarih { get; set; }
    }
}
