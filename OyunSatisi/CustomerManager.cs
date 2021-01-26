using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    public class CustomerManager : CustomerCheckAdapter, ICustomerManager
    {
        
        public void Add(Customer customer)
        {
            
            if (CheckValidPerson(customer)==true)
            {
                // Kaydetme işlemleri
                Console.WriteLine("Kayıt başarılı.");
            }
            else
            {
                throw new Exception("Kayıt işlemi sırasında bilinmeyen bir hata oluştu.");
            }
        }

        public override bool CheckValidPerson(Customer customer)
        {
            // Bilgiler e-devlet veri tabanındaki bilgilerle karşılaştırılır, bool değer döndüren bir metot kullanılır.
            bool result = true; // Karşılaştırma işleminin sonucu buraya gelecek. E-devletten nasıl kontrol sağlayacağımı
            //bilmediğim için true geldiğini varsaydım.
            return result;
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} isimli kullanıcı silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} isimli kullanıcının bilgileri güncellendi.");
        }
    }
}
