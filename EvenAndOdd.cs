using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class EvenAndOdd
    {
        public void EvenAndOddNum() 
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if ( num % 2 == 0 )
            {
                Console.WriteLine("{0} is Even number " + num);
            }
            else
            {
                Console.WriteLine("{0} is Odd number " + num);
            }
        }
    }
}
