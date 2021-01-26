using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public interface IProjectManager<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
