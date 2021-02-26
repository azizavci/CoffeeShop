using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        //eğer başka bir zaman diliminde diğer firma da mernis doğrulaması isterse onun customer manager sınıfında
        //save metodu override edilerek işlem yapılabilir
        public override void Save(Customer customer)
        {
            //burada mernis doğrulaması kodunu hayata geçirebiliriz
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
        }

        
    }
}
