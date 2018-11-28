﻿using TechnoSale.Core.DataAccess;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        //Custom Operations
    }
}
