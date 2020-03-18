using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
//using System.Windows.Forms;

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
            calc.name = Console.ReadLine();

            while (int.TryParse(calc.name, out test)) {
                Console.WriteLine("Please do not have any numbers or special characters in your name");
                Console.WriteLine("What is your name? Enter it below: ");
                calc.name = Console.ReadLine();
            }

            Console.WriteLine("Hello {0}! We are now going to calculate your mortgage. Would you like to:\n1. Calculate the monthly cost of your mortgage\n2. Calculate the maximum amount of money you can take out for a loan\n3. Exit the program", calc.name);
            Console.WriteLine("Enter the number of the choice you pick: ");

            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 3) {
                switch(choice)
                {
                case 1: 
                    Console.WriteLine("You have chosen to calcluate your monthly cost");
                    calc.monthlyCost();
                    break;
                case 2:
                    Console.WriteLine("You have chosen to calculate your maximum amount");
                    maximumLoan();
                    break;
                case 3:
                    Console.WriteLine("You have chosen to exit the program\nHave a great day!");
                    break;
                default:
                    Console.WriteLine("I'm sorry, please choose a valid option");
                    break;
                }
                Console.WriteLine("Would you like to:\n1. Calculate the monthly cost of your mortgage\n2. Calculate the maximum amount of money you can take out for a loan\n3. Exit the program");
                Console.WriteLine("Enter the number of the choice you pick: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have chosen to exit the program\nHave a great day!");
            Console.WriteLine("Look out for more future .NET Framework and C# applications from me!");
        }
    
        /**
        * Calculates the total monthly cost of the mortgage
        *
        * @param 
        */
        public int monthlyCost() {
            Console.WriteLine("Please enter the specified amount of your mortgage: ");
            amount = Convert.ToInt32(Console.ReadLine());
            while (amount < 0) {
                Console.WriteLine("You need to enter a positive number for your mortgage");
                Console.WriteLine("Please enter the specified amount of your mortgage: ");
                amount = Convert.ToInt32(Console.ReadLine());
            }

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
