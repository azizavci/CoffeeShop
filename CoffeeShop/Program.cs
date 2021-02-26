using CoffeeShop.Abstract;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServisAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1994, 10, 10), FirstName = "aziz", LastName = "avcı", NationalityId = "46444942568" });
            Console.ReadLine();
        }
    }
}
