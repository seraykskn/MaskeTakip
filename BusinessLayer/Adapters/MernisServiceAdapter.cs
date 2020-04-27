using BusinessLayer.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Adapters
{
    public class MernisServiceAdapter : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {

            //mernis kontrolü yapılacak.
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            try
            {

                return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalId, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;


            }
            catch (Exception e)
            {
                Console.WriteLine("The service operation timed out. " + e.Message);
                client.Abort();
                Console.ReadLine();
            }
            // Catch the contractually specified SOAP fault raised here as an exception.
            return true;
            // return client.TCKimlikNoDogrulaAsync(person.NationalId, person.FirstName, person.LastName, person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;  

        
    }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
