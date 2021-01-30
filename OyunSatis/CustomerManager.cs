using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public class CustomerManager : ICustomerService
    {
        ICustomerValidationService _customerValidationService;

        public CustomerManager(ICustomer gamer, ICustomerValidationService gamerValidationService)
        {
                _customerValidationService = gamerValidationService;
        }

        public void Add(Customer customer)
        {
            if (_customerValidationService.Validate(customer) == true)
            {
                Console.WriteLine("Kullanıcı kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Kayıt sırasında beklenmeyen bir hatayla karşılaşıldı.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
