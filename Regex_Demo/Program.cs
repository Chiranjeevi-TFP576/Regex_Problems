﻿namespace Regex_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("Enter 1 for First Name\nEnter 2 for Last Name\nEnter 3 for Email\nEnter 4 for MobileNumber");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: //First Name
                    RegexCheck obj = new RegexCheck();
                    Console.WriteLine("Enter a FirstName");
                    string FirstName = Console.ReadLine();
                    obj.Name(FirstName);
                break;
                case 2: //Last Name
                    UC2_LastName CheckLastName = new UC2_LastName();
                    Console.WriteLine("Enter a LastName");
                    string LastName = Console.ReadLine();
                    CheckLastName.Name(LastName);
                    break;
                case 3: //ValidEmail
                    UC3_Email CheckEmail = new UC3_Email();
                    Console.WriteLine("Enter a EmailAdress");
                    string Email = Console.ReadLine();
                    CheckEmail.Name(Email);
                    break;
                case 4: //MobileNumber
                    UC4_MobileNumber checkMobileNumber = new UC4_MobileNumber();
                    Console.WriteLine("Enter a MobileNumber");
                    string Mobile = Console.ReadLine();
                    checkMobileNumber.Name(Mobile);
                    break;
                default:
                    Console.WriteLine("End Of the Programme");
                    break;

            }
        }
    }
}