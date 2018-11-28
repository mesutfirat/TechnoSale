using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class Efsepet_urunDal : EfEntityRepositoryBase<sepet_urun, TechnoSaleContext>, Isepet_urunDal
    {
    }
}
