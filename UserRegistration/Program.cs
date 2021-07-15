using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------User Registration----------------");
            User user = new User();
            user.ValidateFirstName();
            user.ValidateLastName();
        }
    }
}
