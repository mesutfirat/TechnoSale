using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Urun : IEntity
    {
        public Urun()
        {
            this.Kampanya = new List<Kampanya>();
            this.sepet_urun = new List<sepet_urun>();
            this.siparis_urun = new List<siparis_urun>();
            this.Yorum = new List<Yorum>();
            this.Urun_Resim = new List<Urun_Resim>();
            this.urun_ozellik = new List<urun_ozellik>();

        }

        [Key]
        public int urun_id { get; set; }
        public string urun_adi { get; set; }
        public string urun_detay { get; set; }
        public string urun_marka { get; set; }
        public int urun_stok { get; set; }
        public decimal urun_fiyat { get; set; }
        public int urun_puan { get; set; }
        public DateTime urun_tarih { get; set; }
        public int kategori_id { get; set; }
        public virtual ICollection<Kampanya> Kampanya { get; set; }
        public virtual ICollection<sepet_urun> sepet_urun { get; set; }
        public virtual ICollection<siparis_urun> siparis_urun { get; set; }
        public virtual ICollection<Yorum> Yorum { get; set; }
        public virtual ICollection<Urun_Resim> Urun_Resim { get; set; }
        public virtual ICollection<urun_ozellik> urun_ozellik { get; set; }
    }
}
