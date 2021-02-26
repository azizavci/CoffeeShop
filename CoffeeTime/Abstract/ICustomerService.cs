using CoffeeTime.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeTime.Abstract
{
    public interface ICustomerService
    {
        //her iki firma için ortak operasyonlar
        void Save(Customer customer);
    }
}
