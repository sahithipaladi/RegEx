using System;
using System.Collections.Generic;

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
                Console.WriteLine("5.Password Validation");
                Console.WriteLine("6.Validating Sample emails");
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
                    case 5:
                        user.ValidatePassword();
                        break;
                    case 6:
                        // Validating Sample Emails............
                        List<string> sampleEmailList = new List<string>()
                        {
                            "abc@yahoo.com",
                            "abc-100@yahoo.com",
                            "abc.100@yahoo.com",
                            "abc111@abc.com",
                            "abc-100@abc.net",
                            "abc.100@abc.com.au",
                            "abc@1.com",
                            "abc@gmail.com.com",
                            "abc+100@gmail.com"
                        };
                        foreach (string emails in sampleEmailList)
                        {
                            if (user.ValidateSampleEmail(emails))
                            { 
                                Console.WriteLine(" [ " + emails + " ]\t is Valid Email");
                            }
                            else
                            {
                                Console.WriteLine(" [ " + emails + " ]\t is Invalid Email");
                            }
                        }
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

    

