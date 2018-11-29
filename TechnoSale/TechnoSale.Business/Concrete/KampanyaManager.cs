using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Business.Abstract;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Concrete
{
    public class KampanyaManager : IKampanyaService
    {
        private IKampanyaDal _kampanyaDal;
        public KampanyaManager(IKampanyaDal kampanyaDal)
        {
            _kampanyaDal = kampanyaDal;
        }
        public void Add(Kampanya kampanya)
        {
            _kampanyaDal.Add(kampanya);
        }

        public void Delete(int kampanya_id)
        {
            _kampanyaDal.Delete(new Kampanya {kampanya_id = kampanya_id });
        }

        public List<Kampanya> GetAll()
        {
            return _kampanyaDal.GetList();
        }

        public List<Kampanya> GetByUrun(int urun_id)
        {
            return _kampanyaDal.GetList(k => k.urun_id == urun_id);
        }

        public void Update(Kampanya kampanya)
        {
            _kampanyaDal.Update(kampanya);
        }
    }
}
