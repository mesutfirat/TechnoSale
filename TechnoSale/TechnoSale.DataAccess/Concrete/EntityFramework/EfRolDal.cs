using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class EfRolDal : EfEntityRepositoryBase<Rol, TechnoSaleContext>, IRolDal
    {
    }
}
