using System;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        
        public string GetPrimeFactors (int numberExtenal)
        {

            string factors="";
            int numberInternal;
            int primeNumber = 2;
            int iterator = 0;
            numberInternal = numberExtenal;

            while (numberInternal != 1)
            {
                
                if ((numberInternal % primeNumber) != 0)
                {
                        primeNumber++;
                        
                }
                else
                {

                    numberInternal /= primeNumber;

                    factors += primeNumber.ToString();

                    iterator++;

                }
                

            }
            
            
            return factors;
        } 
        
    }
}
