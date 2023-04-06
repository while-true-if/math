using System;
namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 1;
            while (i <= 15)
            {
                i ++ ;
                n *= i;
                Console.WriteLine(">>> " + i + "! = " + n);
            }
        }
    }
}
