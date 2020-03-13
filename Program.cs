using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

/*****************************************
* This class simulates a simple mortgage 
* calculator in the .NET Framework
*
* @author Alec Allain
* @version 03/12/2020
*****************************************/

// Everything is controlled under this namespace
// Namespaces in C# act like classes 
namespace MortgageCalculator
{
    class Calculator
    {
        // Instance variables for calculator class
        private string name {get; set;}
        private int amount {get; set;}
        private int years {get; set;}
        private double rate {get; set;}
        private static int test = 0;
        private static int choice = 0;
        private static bool result = true;

        /**
        * Main method
        */
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("Hello World!");
            Console.WriteLine("This program is a test to show my introductory knowledge to the C#");

            Calculator calc = new Calculator();

            Console.WriteLine("What is your name? Enter it below: ");
            while (int.TryParse(Console.ReadLine(), out test)) {
                Console.WriteLine("Please do not have any numbers in your name");
                Console.WriteLine("What is your name? Enter it below: ");
            }

            Console.WriteLine("Hello {0}! We are now going to calculate your mortgage\nWould you like to calculate the monthly cost of your mortgage\nor would you like to calculate the maximum amount of money you can take out for a loan?", calc.name);
            switch(choice)
            {
                case 1: 
                    Console.WriteLine("You have chosen to calcluate your monthly cost");
                    break;
                case 2:
                    Console.WriteLine("You have chosen to calculate your maximum amount");
                    break;
                case 3:
                    Console.WriteLine("You have chosen to exit the program\nHave a great day!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, please choose a valid option");
                    break;
            }

        }
    
        /**
        * Calculates the total monthly cost of the mortgage
        *
        * @param 
        */
        static int monthlyCost() {
            return 0;
        }

        /**
        * Calculates the total amount a client borrow
        *
        * @param 
        */
        static int maximumLoan() {
            return 0;
        }
    }
}
