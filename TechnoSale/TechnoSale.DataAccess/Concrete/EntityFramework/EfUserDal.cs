using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TechnoSaleContext>, IUserDal
    {
    }
}
