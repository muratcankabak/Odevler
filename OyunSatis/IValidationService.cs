using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public interface IValidationService<T> where T:ICustomer
    {
        public bool Validate(T entity);
    }
}
