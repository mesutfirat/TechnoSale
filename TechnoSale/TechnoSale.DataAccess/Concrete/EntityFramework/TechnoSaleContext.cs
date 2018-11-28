using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class TechnoSaleContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localhost);Database=alisveris; Trusted_Connection=true");
        }

        public DbSet<Kampanya> Kampanyas { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<kategori_ozellik> kategori_ozelliks { get; set; }
        public DbSet<Oneri> Oneris { get; set; }
        public DbSet<Ozellik> Ozelliks { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Sepet> Sepets { get; set; }
        public DbSet<sepet_urun> sepet_uruns { get; set; }
        public DbSet<Siparis> Sipariss { get; set; }
        public DbSet<siparis_urun> siparis_uruns { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<urun_ozellik> urun_ozelliks { get; set; }
        public DbSet<Urun_Resim> Urun_Resims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<user_rol> user_rols { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
    }
}
