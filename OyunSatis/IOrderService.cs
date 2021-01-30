using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public interface IOrderService<T> where T:class, IProduct, new()
    {
        public void Sell(T entity, Customer gamer, SpecialOffer offer);
    }
}
