using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public class BaseCustomerManager : ISupplierService
    {
        public virtual void GiveMask(Person person)
        {
            Console.WriteLine("Given mask and Saved to db : " + person.FirstName);
        }
    }
}
