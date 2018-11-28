using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class Efuser_rolDal : EfEntityRepositoryBase<user_rol, TechnoSaleContext>, Iuser_rolDal
    {
    }
}
