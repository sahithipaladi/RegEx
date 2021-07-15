using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace RegExpression
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
    }
}
    

