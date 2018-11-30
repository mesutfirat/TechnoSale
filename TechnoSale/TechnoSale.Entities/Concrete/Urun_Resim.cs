using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Urun_Resim : IEntity
    {
        [Key]
        public int resim_id { get; set; }
        public string resim_url { get; set; }
        public int urun_id { get; set; }
    }
}
