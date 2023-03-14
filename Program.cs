using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocome to Functional program");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute\n1. Flip Coin\n2. Leap Year\n3. Power of 2\n4. Harmonic Number \n5. Factors\n6. Quotient and Remainder\n7. Swap number\n8. Even and Odd number\n9. Check Alphabet\n10. Largest Number\n11. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        Console.WriteLine("Enter num of flips");
                        int num = Convert.ToInt32(Console.ReadLine());
                        flip.Flip(num);
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        Console.WriteLine("Enter Year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        leap.Leap(year);
                        break;
                    case 3:
                        PowerOf2 powerOf2 = new PowerOf2();
                        Console.WriteLine("Enter Power");
                        int pow = Convert.ToInt32(Console.ReadLine());
                        powerOf2.Display(pow);
                        break;
                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        Console.WriteLine("Enter Number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        harmonicNumber.HarmonicNum(n);
                        break;
                    case 5:
                        Factors factors = new Factors();
                        Console.WriteLine("Enter a number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        factors.PrimeFactor(number);
                        break;
                    case 6:
                        QuotientAndRemainder quotientRemainder = new QuotientAndRemainder();
                        quotientRemainder.QuotientRemainder();
                        break;
                    case 7:
                        SwapNumber swapNumber = new SwapNumber();
                        swapNumber.SwapNum();
                        break;
                    case 8:
                        EvenAndOdd evenAndOdd = new EvenAndOdd();
                        evenAndOdd.EvenAndOddNum();
                        break;
                    case 9:
                        VowelAndConsonant vowelAndConsonant = new VowelAndConsonant();
                        Console.WriteLine("Enter an Alphabet ");
                        char alphabet = Convert.ToChar(Console.ReadLine());
                        vowelAndConsonant.Alphabet(alphabet);
                        break;
                    case 10:
                        LargestNumber largestNumber = new LargestNumber();
                        Console.WriteLine("Enter first number = ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number = ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter third number = ");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        largestNumber.LargestNum(num1,num2,num3);
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}