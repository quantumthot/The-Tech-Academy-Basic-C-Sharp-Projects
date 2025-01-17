﻿using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    int size = (width * height * length * weight);
                    int cost = (size / 100);
                    Console.WriteLine("Your estimated total for shipping the package is: $" + cost);
                }
            }
        }
    }
}
