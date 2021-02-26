using CoffeeTime.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeTime.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("saved to db : "+customer.FirstName);
        }
    }
}
