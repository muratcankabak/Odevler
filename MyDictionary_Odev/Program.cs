using System;
using System.Collections.Generic;

namespace MyDictionary_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> kisiler = new MyDictionary<int, string>();
            kisiler.Add(1,"Ahmet");
            kisiler.Add(2,"Mehmet");
        }
    }
}
