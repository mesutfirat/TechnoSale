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
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=alisveris; Trusted_Connection=true");
        }

        public DbSet<Kampanya> Kampanya { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<kategori_ozellik> kategori_ozellik { get; set; }
        public DbSet<Oneri> Oneri { get; set; }
        public DbSet<Ozellik> Ozellik { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<sepet_urun> sepet_urun { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<siparis_urun> siparis_urun { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<urun_ozellik> urun_ozellik { get; set; }
        public DbSet<Urun_Resim> Urun_Resim { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<user_rol> user_rol { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
    }
}
