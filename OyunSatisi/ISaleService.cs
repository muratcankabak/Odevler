using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public interface ISaleService <T> where T: IProduct
    {
        public void Sell(T product, Customer customer, SpecialOffer offer);
    }
}
