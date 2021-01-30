using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatis
{
    public class CustomerValidationManager : ICustomerValidationService
    {
        public bool Validate(ICustomer entity)
        {
            // Mernisten gerekli verileri çektiğimizi ve validasyonun  sağlandığını varsayacağız.
            var dataMernis = 0;
            var dataFromUser = 0;
            bool result;

            if (dataFromUser == dataMernis)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }
    }
}
