using Microsoft.Win32.SafeHandles;
using System;
using System.Net.Cache;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Flyguy = new Bird();
            Flyguy.Age = 10;
            Flyguy.Name = "Flydude";
            Flyguy.HasFur = false;
            Flyguy.type = "Cardinal";
            Flyguy.wings = 6;
            Flyguy.HasFeathers = true;
            Flyguy.IsTropical = true;

            Console.WriteLine($"{Flyguy.Name} is {Flyguy.Age} years old he is a purple {Flyguy.type} who has {Flyguy.wings}.");
            Console.WriteLine($"Does {Flyguy.Name} have fur, feathers and is he from the tropics?" + 
                $"{Flyguy.HasFur}, {Flyguy.HasFeathers}, {Flyguy.IsTropical}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Snake = new Reptile();
            Snake.Age = 12;
            Snake.Name = "Snakey";
            Snake.HasFur = false;
            Snake.Legs = 0;
            Snake.IsExtinct = false;
            Snake.HasScales = true;
            Snake.HasShell = false;
            Snake.HasLegs = false;

            Console.WriteLine($"{Snake.Name} is {Snake.Age} years old he has {Snake.Legs} legs");
            Console.WriteLine($"Does {Snake.Name} have fur or does he have scales?Is he trapped in a shell? Does he have legs? is he extinct?" +
                $"{Snake.HasFur},{ Snake.HasScales},{ Snake.HasShell},{ Snake.HasLegs},{Snake.IsExtinct}");

        }
    }
}
