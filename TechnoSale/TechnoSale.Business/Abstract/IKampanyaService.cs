using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Abstract
{
    public interface IKampanyaService
    {
        List<Kampanya> GetAll();
        List<Kampanya> GetByUrun(int urun_id);
        void Add(Kampanya kampanya);
        void Update(Kampanya kampanya);
        void Delete(int kampanya_id);

    }
}
