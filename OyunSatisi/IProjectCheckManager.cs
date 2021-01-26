using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public interface IProjectCheckManager<T> where T : IPerson // İleride örneğin personellerin de
        // e-devletten kimlik doğrulaması istenirse, koda müdahale etmeden 
    {
        public bool CheckValidPerson (T entity);
    }
}
