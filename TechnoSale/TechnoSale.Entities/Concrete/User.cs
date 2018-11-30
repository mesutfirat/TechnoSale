using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class User : IEntity
    {
        public User()
        {
            this.user_rol = new List<user_rol>();
            this.Siparis = new List<Siparis>();
            this.Yorum = new List<Yorum>();
            this.Oneri = new List<Oneri>();
        }

        [Key]
        public int user_id { get; set; }
        public string user_adi { get; set; }
        public string user_soyadi { get; set; }
        public DateTime user_dogum_tarihi { get; set; }
        public string user_email { get; set; }
        public string user_sifre { get; set; }
        public string user_adres { get; set; }
        public string user_telefon { get; set; }
        public virtual ICollection<user_rol> user_rol { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual ICollection<Yorum> Yorum { get; set; }
        public virtual ICollection<Oneri> Oneri { get; set; }
    }
}
