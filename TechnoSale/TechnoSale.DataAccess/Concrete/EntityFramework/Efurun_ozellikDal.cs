using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class Efurun_ozellikDal : EfEntityRepositoryBase<urun_ozellik, TechnoSaleContext>, Iurun_ozellikDal
    {
    }
}
