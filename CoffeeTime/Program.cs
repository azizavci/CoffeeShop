
using CoffeeTime.Abstract;
using CoffeeTime.Concrete;
using CoffeeTime.Entities;
using System;

namespace CoffeeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1994, 10, 10), FirstName = "aziz", LastName = "avcı", NationalityId = "46444942568" });
        }
    }
}
