using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using MernisServiceReference;
using System;

namespace CoffeeShop
{
    public class MernisServisAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            long tc = Convert.ToInt64(customer.NationalityId);
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(tc, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
