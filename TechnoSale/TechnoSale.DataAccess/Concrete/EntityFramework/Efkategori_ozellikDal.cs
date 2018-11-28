using TechnoSale.Core.DataAccess.EntityFramework;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Concrete.EntityFramework
{
    public class Efkategori_ozellikDal : EfEntityRepositoryBase<kategori_ozellik, TechnoSaleContext>, Ikategori_ozellikDal
    {
    }
}
