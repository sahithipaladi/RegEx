using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class User
    {
        string pattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        /// <summary>
        /// UC - 1  Validating the First Name
        /// </summary>
        public void ValidateFirstName()
        {
            Console.WriteLine("Enter a First Name to validate : ");
            string firstName = Console.ReadLine();
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(firstName);
            if (result)
                Console.WriteLine("It is valid");
            else
                Console.WriteLine("It is not valid");
        }

        /// <summary>
        /// UC - 2  Validating the Last Name
        /// </summary>
        public void ValidateLastName()
        {
            Console.WriteLine("Enter a Last Name to validate : ");
            string lastName = Console.ReadLine();
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(lastName);
            if (result)
                Console.WriteLine("It is valid");
            else
                Console.WriteLine("It is not valid");
        }
    }
}