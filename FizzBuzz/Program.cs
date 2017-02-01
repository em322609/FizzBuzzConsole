using System;
using FizzBuzz;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a minimum value: ");
            string sMin = Console.ReadLine();
            int iMin = Convert.ToInt32(sMin);

            Console.Write("Please enter a maximum value: ");
            string sMax = Console.ReadLine();
            int iMax = Convert.ToInt32(sMax);


            if (iMin < iMax)
            {
                FizzBuzz fizz = new FizzBuzz(iMin, iMax);
            }
            else
            {
                FizzBuzz fizz = new FizzBuzz(iMax, iMin);
            }
    


                Console.ReadLine();
            
        }
    }
}
