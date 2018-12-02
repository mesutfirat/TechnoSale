using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Business.Abstract;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }
        public void Add(Kategori kategori)
        {
            _kategoriDal.Add(kategori);
        }

        public void Delete(int kategori_id)
        {
            _kategoriDal.Delete(new Kategori { kategori_id = kategori_id });
        }

        public List<Kategori> GetAll()
        {
            return _kategoriDal.GetList();
        }

        public void Update(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }
    }
}
