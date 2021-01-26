using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public abstract class CustomerCheckAdapter : IProjectCheckManager<Customer>
    {
        public virtual bool CheckValidPerson(Customer customer)
        {
            //  E-devlete bağlanıp doğrulamanın yapılacağı yer burası. Adapter yardımıyla uygulamamıza
            //esneklik kazandırdık. Bu kodu direkt olarak CustomerManagerda yazsaydık ileride e-devlet
            //yerine başka bir veri tabanı kullanmak istediğimizde bu kod bloğunu her yerde teker teker
            //değiştirmemiz gerekecekti. Şimdi ise virtualla işaretledik ve kendisini inherit eden bütün
            //classlarda bu metodun override edilmesini zorunlu tuttuk. Buradan true değer döndüğünü var-
            //sayacağız.
            return true;
        }
    }
}
