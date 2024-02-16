// system namespace needed to use the console class
using System;

// my collection of classes for this project

namespace HelloWorld_Jackson_Lydia
{
    // main class for our program
    internal class Program
    {
        // the main method is executed when the application starts
        static void Main(string[] args)
        {
            // asks the user for first name
            Console.WriteLine("What is your first name?");
            // assigns user input to firstName variable
            string firstName = Console.ReadLine();
            // asks the user for last name
            Console.WriteLine("What is your last name?");
            // assigns user input to lastName variable
            string lastName = Console.ReadLine(); 

            // prints a welcome message with firstName and lastName
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}