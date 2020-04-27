using BusinessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class PttManager : BaseCustomerManager
    {
        private IApplicantService _applicantService;

        public PttManager()
        { }

        public  PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        
        }

        public override void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person))
            {
                base.GiveMask(person);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }

        //public void GiveMask(Person person)
        //{

        //    if (_applicantService.CheckPerson(person))
        //    {
        //        Console.WriteLine(person.FirstName + " için maske verildi.");

        //    }

        //    else
        //    {
        //        Console.WriteLine(person.FirstName + " İÇİN MASKE VERİLEMEDİ.");
        //    }


        //}
    }
}
