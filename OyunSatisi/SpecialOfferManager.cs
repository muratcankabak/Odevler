using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class SpecialOfferManager : IProjectManager<SpecialOffer>
    {
        public void Add(SpecialOffer offer)
        {
            Console.WriteLine($"{offer.OfferName} isimli kampanya başarıyla eklendi.");
        }

        public void Delete(SpecialOffer offer)
        {
            Console.WriteLine($"{offer.OfferName} isimli kampanya başarıyla kaldırıldı.");
        }

        public void Update(SpecialOffer offer)
        {
            Console.WriteLine($"{offer.OfferName} isimli kampanya başarıyla güncellendi.");
        }
    }
}
