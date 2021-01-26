using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class GameSaleServiceCash : ISaleService<Game>
    {
        public void Sell(Game product, Customer customer, SpecialOffer offer)
        {
            Console.WriteLine($"{product.ProductName} isimli {product.Category}, {customer.FirstName} {customer.LastName} " +
            $"adlı kullanıcıya {product.UnitPrice * 85 / 100} TL'ye satıldı, müşteri '{offer.OfferName}' adlı kampanyadan yararlandı." +
            $" {offer.Description} uygulandı. Ödeme nakit yapıldı.");
        }
    }
}
