﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class PowerOf2
    {
        public void Display(int num)
        {
            for (int i = 0; i < num && num < 31; i++)
            {
                Console.WriteLine("2^"+i+"="+Math.Pow(2,i));
            }
        }
    }
}