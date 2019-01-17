using System;
using System.Collections.Generic;
using System.Text;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Abstract
{
    public interface ICartService
    {
        void AddToCard(Cart cart, Urun urun);
        void RemoveFromCard(Cart cart, int urun_id);
        List<CartLine> List(Cart cart);
    }
}
