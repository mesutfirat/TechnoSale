using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetAll();
        List<Urun> GetByKategori(int kategori_id);
        void Add(Urun urun);
        void Update(Urun urun);
        void Delete(int urun_id);
        Urun GetById(int urun_id);
    }
}
