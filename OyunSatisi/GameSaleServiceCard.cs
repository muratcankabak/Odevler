using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class GameSaleServiceCard : ISaleService<Game>
    {
        public void Sell(Game product, Customer customer, SpecialOffer offer)
        {
            offer = null;
            Console.WriteLine($"{product.ProductName} isimli {product.Category}, {customer.FirstName} {customer.LastName} " +
            $"adlı kullanıcıya {product.UnitPrice} TL'ye satıldı, müşteri kredi kartıyla ödeme yaptığı için kampanyadan" +
            $"faydalanamadı.");
        }
    }
}
