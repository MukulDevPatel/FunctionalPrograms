using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class HarmonicNumber
    {
        public void HarmonicNum(int num) 
        {
            double output = 0;
            for (double i = 1; i <= num; i++)
            {
                output+=1/i;
                Console.WriteLine("1/" + i);
                if (i < num)
                    Console.WriteLine("+");
            }
            
            Console.WriteLine("Harmonic number is "+output);
        }
    }
}
