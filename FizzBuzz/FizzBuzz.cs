using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string[] result;
        public FizzBuzz()
        {
            result = new string[15];
            SetValues();
        }

        public FizzBuzz(int min, int max)
        {
           
            int size = max - min;
            result = new string[size];
            SetValues();
        }

        private void SetValues()
        {
            for (int i = 0; i < result.Length; i++)
            {
                if((i % 5 == 0) && (i % 3 == 0))
                {
                    result[i] = "fizzbuzz";
                }
                else if(i % 3 == 0)
                {
                    result[i] = "fizz";
                }
                else if(i % 5 == 0)
                {
                    result[i] = "buzz";
                }
                else
                {
                    result[i] = "" + i;
                }

            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
