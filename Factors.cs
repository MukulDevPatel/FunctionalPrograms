using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Factors
    {
        public void PrimeFactor(int num) //6 -> 2,3
        {
            Console.WriteLine("Prime Factors of " + num +  " are:");
            for (int i = 2; i <= num; i++) 
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;
                }
            }
        }
    }
}
