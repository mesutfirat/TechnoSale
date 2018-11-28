using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;

namespace TechnoSale.Entities.Concrete
{
    public class Urun : IEntity
    {
        public Urun()
        {
            this.Kampanya = new List<Kampanya>();
            this.Sepet = new List<Sepet>();
            this.Siparis = new List<Siparis>();
            this.Yorum = new List<Yorum>();
            this.Urun_Resim = new List<Urun_Resim>();
            this.Ozellik = new List<Ozellik>();

        }

        public int urun_id { get; set; }
        public string urun_adi { get; set; }
        public string urun_detay { get; set; }
        public string urun_marka { get; set; }
        public int urun_stok { get; set; }
        public decimal urun_fiyat { get; set; }
        public float urun_puan { get; set; }
        public DateTime urun_tarih { get; set; }
        public int kategori_id { get; set; }
        public virtual ICollection<Kampanya> Kampanya { get; set; }
        public virtual ICollection<Sepet> Sepet { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
        public virtual ICollection<Yorum> Yorum { get; set; }
        public virtual ICollection<Urun_Resim> Urun_Resim { get; set; }
        public virtual ICollection<Ozellik> Ozellik { get; set; }
    }
}
