using System;
using System.Text.RegularExpressions;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please Enter name: ");

                //Name Test
                string name = Console.ReadLine();
                string namePattern = @"^[A-Z].{1,30}$";

                if (Regex.IsMatch(name, namePattern))
                {
                    Console.WriteLine("Name valid");
                }
                else
                {
                    Console.WriteLine("Name INVALID ");
                }

                //Email Test
                Console.Write("Please Enter your email address: ");
                string email = Console.ReadLine();
                string emailPattern = @"^[A-z]{5,30}@[A-z]{1,10}.[A-z]{2,3}$";

                if (Regex.IsMatch(email, emailPattern))
                {
                    Console.WriteLine("Email Address valid");
                }
                else
                {
                    Console.WriteLine("Email Address INVALID ");
                }

                //Phone Test
                Console.Write("Please Enter your phone number: ");
                string phone = Console.ReadLine();
                string phonePattern = @"^[1-9]{3}-[0-9]{3}-[0-9]{4}$";

                if (Regex.IsMatch(phone, phonePattern))
                {
                    Console.WriteLine("Phone number valid");
                }
                else
                {
                    Console.WriteLine("Phone Number INVALID ");
                }

                //Date Test
                Console.Write("Enter the Date in mm/dd/yyyy format: ");
                string date = Console.ReadLine();
                string datePattern = @"[0-9]{2}\/[0-9]{2}\/[0-9]{4}$";

                if (Regex.IsMatch(date, datePattern))
                {
                    Console.WriteLine("Date format valid");
                }
                else
                {
                    Console.WriteLine("Date format INVALID ");
                }

            }
        }
    }
}
