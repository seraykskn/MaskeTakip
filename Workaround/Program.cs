using BusinessLayer.Abstract;
using BusinessLayer.Adapters;
using BusinessLayer.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    public class Program
    {

        
        public static void Main(string[] args)
        {
            //Degiskenler()
            
            BaseCustomerManager customerManager = new PttManager(new MernisServiceAdapter());
            customerManager.GiveMask(new Person { DateOfBirthYear = 1993, FirstName = "SERAY", LastName = "KESKİN", NationalId = 27332648456 });
            Console.ReadLine();
        
        }
    }
}
