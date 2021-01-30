using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public class OrderGameManagerCash : IOrderService<Product>
    {
        public void Sell(Product game, Customer gamer, SpecialOffer offer)
        {
            Console.WriteLine($"{game.ProductName} isimli {game.Category}, {gamer.FirstName} {gamer.LastName} adlı" +
           $"müşteri tarafından satın alındı. Müşteri nakit ödeme yaptı. Bu sayede {offer.OfferName} isimli" +
           $"kampanyadan yararlandı. {offer.Description} uygulandı. ");
        }
    }
}