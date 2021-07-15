using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------User Registration----------------");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.First Name Validation");
                Console.WriteLine("2.Last Name Validation");
                Console.WriteLine("3.Email Validation");
                Console.WriteLine("4.Mobile Number Validation");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Choose an option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                User user = new User();
                switch (option)
                {
                    case 1:
                        user.ValidateFirstName();
                        break;
                    case 2:
                        user.ValidateLastName();
                        break;
                    case 3:
                        user.ValidateEmail();
                        break;
                    case 4:
                        user.ValidateMobileNumber();
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}