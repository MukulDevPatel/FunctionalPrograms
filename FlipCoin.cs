using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class FlipCoin
    {
        const double VALIDATION_CHECK = 0.5;
        public void Flip(int numOfTimes)
        {
            int head = 0, tail = 0;
            Random random = new Random();
            for (int i = 0; i < numOfTimes; i++)
            {
                double value = random.NextDouble(); // 0 to 1
                if (value < VALIDATION_CHECK)
                    tail++;
                else
                    head++;
            }
            double headPercentage = (head/numOfTimes) * 100;
            double tailPercentage = (tail/numOfTimes) * 100;
            Console.WriteLine("Head Percenatge---> " + headPercentage + "\nTail Percentage--->" + tailPercentage);
        }
    }
}
