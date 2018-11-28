using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class EfKategoriDal : EfEntityRepositoryBase<Kategori, TechnoSaleContext>, IKategoriDal
    {
    }
}
