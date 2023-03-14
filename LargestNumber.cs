using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LargestNumber
    {
        public void LargestNum(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
                Console.WriteLine("This is largest number " + num1);
            if (num2 > num3 && num2 > num1)
                Console.WriteLine("This is Largest number " + num2);
            else
                Console.WriteLine("This is Largest number " + num3);
        }
    }
}
