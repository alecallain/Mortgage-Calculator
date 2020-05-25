using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading;
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
        // Instance/Global variables for calculator class
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

            // Determines if there's any special characters in the string the user enters
            while (int.TryParse(calc.name, out test))
            {
                Console.WriteLine("Please do not have any numbers or special characters in your name");
                Console.WriteLine("What is your name? Enter it below: ");
                calc.name = Console.ReadLine();
            }

            // User picks from three different options
            Console.WriteLine("Hello {0}! We are now going to calculate your mortgage. Would you like to:\n1. Calculate the monthly cost of your mortgage\n2. Calculate the maximum amount of money you can take out for a loan\n3. Exit the program", calc.name);
            Console.WriteLine("Enter the number of the choice you pick: ");

            // Continuous loop so the program doesnt abruptly end unless specified
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 3)
            {
                switch(choice)
                {
                case 1: 
                    Console.WriteLine("You have chosen to calcluate your monthly cost");
                    calc.monthlyCost();
                    break;
                case 2:
                    Console.WriteLine("You have chosen to calculate your maximum loan amount");
                    calc.maximumLoan();
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
        * @return final monthly payment to the user
        */
        private double monthlyCost() 
        {
            // Local variables for method
            double monthlyPayment = 0;
            double paymentCount = 0;

            // Method constantly checks to determine if correct format of numbers is entered
            Console.WriteLine("Please enter the specified amount of your mortgage: ");
            amount = Convert.ToInt32(Console.ReadLine());
            while (amount < 0) 
            {
                Console.WriteLine("You need to enter a positive number for your mortgage");
                Console.WriteLine("Please enter the specified amount of your mortgage: ");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please enter the interest rate of your mortgage: ");
            rate = Convert.ToInt32(Console.ReadLine());
            while (rate < 0) 
            {
                Console.WriteLine("Please enter the correct format for interest");
                Console.WriteLine("Please enter the interest rate of your mortgage: ");
                rate = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please enter the amount of years you're paying for your mortgage: ");
            years = Convert.ToInt32(Console.ReadLine());
            while (years < 0) 
            {
                Console.WriteLine("Please make sure the years are positive");
                Console.WriteLine("Please enter the amoutn of years you're paying for your mortgage: ");
                years = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your monthly payment will now be calculated...");

            Thread.Sleep(TimeSpan.FromSeconds(10));

            paymentCount = years * 12;
            monthlyPayment = amount * (rate * Math.Pow(1 + rate, paymentCount)) / ((Math.Pow(1 + rate, paymentCount)) - 1);

            Console.WriteLine("Your monthly payment for your mortgage is: $" + monthlyPayment + " per month");

            return monthlyPayment;
        }

        /**
        * Calculates the total amount a client can borrow for a mortgage
        *
        * @return total mortgage amount
        */
        private double maximumLoan() 
        {
            // Local variables for method
            double maxLoan = 0;
            double monthlyPayment = 0;
            double paymentCount = 0;

            Console.WriteLine("Please enter the amount you pay monthly on your mortgage: ");
            monthlyPayment = Convert.ToInt32(Console.ReadLine());
            while (monthlyPayment < 0) {
                Console.WriteLine("You need to enter a valid amount for your monthly payment.");
                Console.WriteLine("Please enter the amount you pay monthly on your mortgage: ");
                monthlyPayment = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter the interest rate of your mortgage: ");
            rate = Convert.ToInt32(Console.ReadLine());
            while (rate < 0) {
                Console.WriteLine("You need to enter a valid amount for your interest rate.");
                Console.WriteLine("Please enter the interest rate of your mortgage: ");
                rate = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter the number of years that your mortgage covers: ");
            years = Convert.ToInt32(Console.ReadLine());
            while(years < 0) {
                Console.WriteLine("You need to enter a valid amount for the years on your mortgage.");
                Console.WriteLine("Please enter the number of years that your mortgage covers: ");
                years = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your maximum loan amount will now be calculated...");

            Thread.Sleep(TimeSpan.FromSeconds(10));

            paymentCount = years * 12;

            maxLoan = monthlyPayment * ((Math.Pow(1 + rate, paymentCount)) - 1) / (rate * Math.Pow(1 + rate, paymentCount));

            Console.WriteLine("The maximum loan you can take out is: $" + maxLoan);

            return maxLoan;
        }
    }
}
