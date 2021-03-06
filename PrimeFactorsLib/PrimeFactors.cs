using System;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        
        public string GetPrimeFactors (int numberExtenal)
        {

            string factors = null;
            int numberInternal;
            int primeNumber = 2;
            int iterator = 0;
            numberInternal = numberExtenal;

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
                        
                            iterator++;
                        }
                        else
                        {
                            factors += primeNumber.ToString();
                            factors += ",";
                            iterator++;
                        }

                    }
                
                }
            }
            return factors;
        } 
        
    }
}
