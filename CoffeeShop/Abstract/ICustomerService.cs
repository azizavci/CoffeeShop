using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Abstract
{
    public interface ICustomerService
    {
        //bu sınıfı implemente eden tüm sınıflar bu metodu
        //kullanmak zorundadır
        void Save(Customer customer);
    }
}
