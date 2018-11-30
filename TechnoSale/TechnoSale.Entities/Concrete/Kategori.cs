using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Kategori : IEntity
    {
        public Kategori()
        {
            this.Urun = new List<Urun>();
            this.kategori_ozellik = new List<kategori_ozellik>();
        }

        [Key]
        public int kategori_id { get; set; }
        public string kategori_adi { get; set; }
        public int ust_kategori_id { get; set; }

        public virtual ICollection<Urun> Urun { get; set; }
        public virtual ICollection<kategori_ozellik> kategori_ozellik { get; set; }
    }
}
