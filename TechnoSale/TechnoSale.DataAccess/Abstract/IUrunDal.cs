using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Core.DataAccess;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Abstract
{
    public interface IUrunDal : IEntityRepository<Urun>
    {
        //Custom Operations
        void Delete(int urun_id);
    }
}
