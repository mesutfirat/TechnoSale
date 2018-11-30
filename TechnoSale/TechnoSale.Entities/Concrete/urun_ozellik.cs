using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class urun_ozellik : IEntity
    {
        [Key]
        public int urun_id { get; set; }
        public int ozellik_id { get; set; }
        public string ozellik_deger { get; set; }
    }
}
