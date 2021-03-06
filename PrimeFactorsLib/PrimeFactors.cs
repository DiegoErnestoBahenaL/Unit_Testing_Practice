using System;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        /// <summary>
        /// This function Gets the prime factors of number between 2 and 1000
        /// </summary>
        /// <param name="numberExternal">The number received by the call of the method</param>
        /// <param name="primeNumber">The prime numbers that will be tested</param>
        /// <param name="numberInternal">This number gets the value to discompose</param>
        /// <param name="factors">If the number is not valid return </param>
        /// <returns>After the number is converted to prime factors the method returns a string separated with "," with each factor</returns>
        public string GetPrimeFactors (int numberExternal)
        {

            string factors = null;
            int numberInternal;
            int primeNumber = 2;
            numberInternal = numberExternal;

            if (numberInternal > 1 && numberInternal < 10001)
            {
                while (numberInternal != 1)
                {
                
                    if ((numberInternal % primeNumber) != 0)
                    {
                        primeNumber++;
                    }
                    else
                    {

                        numberInternal /= primeNumber;

                        if (numberInternal == 1)
                        {
                            factors += primeNumber.ToString();
    
                        }
                        else
                        {
                            factors += primeNumber.ToString();
                            factors += ",";
                        
                        }

                    }
                
                }
            }
            return factors;
        } 
        
    }
}
