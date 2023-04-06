using System;
namespace factorial_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 1;
            int m = 0;
            while (i <= 11)
            {
                i ++ ;
                n *= i;
                m += n;
                Console.WriteLine(">>> 1! + ~" + i + "! = " + m);
            }
        }
    }
}