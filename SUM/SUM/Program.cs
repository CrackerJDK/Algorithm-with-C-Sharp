using System;

namespace SUM
{

    /**
     * Calculate the sum of the following numbers:
     *
     * 1+ 3/2 + 5/4 + 7/8 + 9/16 +...+ 37/?
     *
     * The question mark is a number according to the law of the sequence of fractions
    **/
    class Program
    {
        public static void Main(string[] args)
        {
            double sum = 1.0d;
            float a = 3.0f;
            float count = 1.0f;
            do
            {
                sum+=a/(Math.Pow(2,count));
                Console.WriteLine(a);
                a+=2;
                count++;
            }
            while(a!=39);
            Console.WriteLine("Sum of the series of fractions: " + sum);
        }
    }
}
