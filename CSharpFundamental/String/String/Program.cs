﻿using System;
namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Hoang Trong ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("-------------------------");
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            Console.WriteLine("-------------------------");
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
            Console.WriteLine("-------------------------");
            Console.WriteLine(fullName.Replace("Hoang", "Cong"));

            if(String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid !");
            }

            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}