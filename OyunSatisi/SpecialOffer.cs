using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class SpecialOffer : IEntity
    {
        public int OfferId { get; set; }
        public string OfferName { get; set; }
        public string Description { get; set; }
    }
}
