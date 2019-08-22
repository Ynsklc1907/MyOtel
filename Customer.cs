using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOtel
{
   public class Customer:BaseClass
    {
        public Customer(string name,string surname,string phoneNumber)
        {
            maxId++;
            Id = maxId;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; set; }

    }
}
