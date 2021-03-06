using System;
using PrimeFactorsLib;
using static System.Console;
namespace FractionsSimplifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
           

            WriteLine("This program will show the prime factors of a number.\nType numbers between 2 and 1000. To exit type Ctrl + C");
        // The program will ask for the number until the user exits with Ctrl + C
        tries:
        
            WriteLine("Type the number");
            numberOne = getNumber();

            //Instance of the class
            var primes = new PrimeFactors();

            string factorsOne = primes.GetPrimeFactors(numberOne);
            //if the output is not null it means all is valid
            if (factorsOne != null) 
            {
                WriteLine ($"The prime factors of the number is {factorsOne}");
            }
            //otherwise will send a message to ask for a valid number
            else
            {
                WriteLine ("Remember in prime numbers there is no negative numbers, also do not type numbers above 1000, neither 1 or 0 (their not primes)");
            }
            goto tries;   

        }
        /// <summary>
        /// This method will get the number typed by the user and determine if it's valid or not
        /// </summary>
        /// <param name="number">The number received by the call of the method</param>
        /// <returns>The number typed until is valid</returns>
        public static int getNumber()
        {
           int number = 0;
        enter:   
            try
            {
                number = int.Parse(ReadLine()); 
            }
             
            catch (FormatException)
            {
                    
                WriteLine("You entered something wrong, remember, in prime numbers\nonly integer numbers are valid");                         
                goto enter;
            }
            return number;
        }
    }
}
