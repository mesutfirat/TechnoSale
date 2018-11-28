using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class EfUrun_ResimDal : EfEntityRepositoryBase<Urun_Resim, TechnoSaleContext>, IUrun_ResimDal
    {
    }
}
