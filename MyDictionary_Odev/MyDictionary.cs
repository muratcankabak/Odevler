using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary_Odev
{
    public class MyDictionary<T, D>  // Generic tipte iki adet array belirliyoruz, biri key diğeri de value değerlerini tutacak. Add operasyonuu yapabilmek için de öncelikle bunlar için 
                                     //birer field oluşturuyoruz.
    {
        T[] _keys;
        D[] _values;
        public MyDictionary()  
        {
            T[] keys = new T[0];
            D[] values = new D[0];
        }
        public void Add(T key, D value)
        {
            T[] tempKeys = _keys;
            D[] tempValues = _values;

            _keys = new T[tempKeys.Length + 1];
            _values = new D[tempValues.Length + 1];

            for (int i = 0; i < _keys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
        // Key ve Value değerleri için ayrı ayrı iki dizi tutulması gerekiyor. Listte yaptığımız işlemin bire bir aynısını yapıyoruz. Sadece işlemleri aynı anda iki farklı array 
        //için yapmış olduk.
    }
}
