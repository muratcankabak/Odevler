using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public interface IProjectService<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
