using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechnoSale.Business.Abstract;
using TechnoSale.Entities.Concrete;

namespace TechnoSale.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCard(Cart cart, Urun urun)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Urun.urun_id == urun.urun_id);
            if (cartLine != null)
            {
                cartLine.urun_adet++;
                return;
            }
            cart.CartLines.Add(new CartLine { Urun = urun,urun_adet = 1 });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCard(Cart cart, int urun_id)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Urun.urun_id == urun_id));
        }
    }
}
