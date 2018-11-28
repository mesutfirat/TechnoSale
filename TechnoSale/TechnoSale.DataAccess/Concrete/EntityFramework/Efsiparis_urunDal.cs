using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class Efsiparis_urunDal : EfEntityRepositoryBase<siparis_urun, TechnoSaleContext>, Isiparis_urunDal
    {
    }
}
