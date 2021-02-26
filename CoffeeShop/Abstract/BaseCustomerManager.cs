
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        //ezilebilir
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db : " + customer.FirstName);
        }
    }
}
