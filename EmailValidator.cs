using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exercise01App
{
    public class EmailValidator
    {
        public void emailValidator()
        {
            Console.WriteLine("Enter an email address to validate: ");
            var input = Console.ReadLine();

            var emailAddress = new EmailAddressAttribute();

            if (new EmailAddressAttribute().IsValid(input))
            {
                Console.WriteLine("Email address passed validation!");
            }
            else
            {
                Console.WriteLine("Email address was incorrect.");
            }
        }
    }
}
