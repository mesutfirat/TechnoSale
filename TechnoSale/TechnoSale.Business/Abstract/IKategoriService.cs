using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> GetAll();
        void Add(Kategori kategori);
        void Update(Kategori kategori);
        void Delete(int kategori_id);
    }
}
