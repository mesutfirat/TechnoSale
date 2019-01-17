using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Business.Abstract;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Concrete
{
    public class UrunManager : IUrunService
    {
        private IUrunDal _urunDal;
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }
        public void Add(Urun urun)
        {
            _urunDal.Add(urun);
        }

        public void Delete(int urun_id)
        {
            _urunDal.Delete(new Urun {urun_id = urun_id });
        }

        public List<Urun> GetAll()
        {
            return _urunDal.GetList();

        }

        public List<Urun> GetByKategori(int kategori_id)
        {
            return _urunDal.GetList(u => u.kategori_id == kategori_id || kategori_id==0);
        }

        
        public void Update(Urun urun)
        {
            _urunDal.Update(urun);
        }

        public Urun GetById(int urun_id)
        {
           return _urunDal.Get(p => p.urun_id == urun_id);
        }
    }
}
