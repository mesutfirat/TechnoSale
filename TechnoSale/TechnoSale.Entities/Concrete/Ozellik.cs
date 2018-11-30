using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Ozellik : IEntity
    {
        public Ozellik()
        {
            this.urun_ozellik = new List<urun_ozellik>();
            this.kategori_ozellik = new List<kategori_ozellik>();
        }

        [Key]
        public int ozellik_id { get; set; }
        public string ozellik_adi { get; set; }
        public virtual ICollection<urun_ozellik> urun_ozellik { get; set; }
        public virtual ICollection<kategori_ozellik> kategori_ozellik { get; set; }
    }
}
