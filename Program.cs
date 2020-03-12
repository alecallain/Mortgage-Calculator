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

        /**
        * Main method
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
