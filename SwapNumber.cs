﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class SwapNumber
    {
        public void SwapNum() 
        { 
            int temp;
            Console.WriteLine("Enter first number = ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number = ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap num1 = " + num1+ ", num2 = " + num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swap num1 = " + num1 + ", num2 = " + num2);
        }
    }
}
